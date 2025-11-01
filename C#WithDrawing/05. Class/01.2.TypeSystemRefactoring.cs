using System;
using System.Drawing;
using System.Windows.Forms;

// behavioral contract: "can move"
public interface IMovable
{
    void Move();
}

// presentation contract: "can be drawn"
public interface IRenderable
{
    Image Image { get; }
    Point Location { get; }
}

// specify movement unit (Δx, Δy) as a value type
public readonly struct Step
{
    public int Dx { get; }
    public int Dy { get; }
    public Step(int dx, int dy) { Dx = dx; Dy = dy; }
    public Point Apply(Point p) => new Point(p.X + Dx, p.Y + Dy);
}

// holds a resource (image), therefore implements IDisposable
public sealed class Car : IMovable, IRenderable, IDisposable
{
    public Image Image { get; }
    public Point Location { get; private set; }
    private readonly Step _step;

    public Car(string imagePath, Point start, Step step)
    {
        Image = Image.FromFile(imagePath); // acquire resource
        Location = start;
        _step = step;
    }

    public void Move() => Location = _step.Apply(Location);

    public void Dispose() => Image?.Dispose(); // release resource
}

public static class Program
{
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using var form = new Form { Text = "Sample", ClientSize = new Size(300, 200) };

        using var car = new Car(
            imagePath: @"c:\car.bmp",
            start: new Point(0, 0),
            step: new Step(10, 10)
        );

        // move twice → (20, 20)
        car.Move();
        car.Move();

        var pb = new PictureBox
        {
            Image = car.Image,
            Location = car.Location,
            SizeMode = PictureBoxSizeMode.AutoSize
        };

        form.Controls.Add(pb);
        Application.Run(form);
    }
}
