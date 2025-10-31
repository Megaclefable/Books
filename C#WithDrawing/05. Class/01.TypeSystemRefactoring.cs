using System;
using System.Drawing;
using System.Windows.Forms;

interface ICar
{
    Image Image { get; }
    Point Position { get; }
    void Move();
}

class Car : ICar
{
    private Image image;
    private Point position;

    public Car(string imagePath)
    {
        image = Image.FromFile(imagePath);
        position = new Point(0, 0);
    }

    public Image Image => image;
    public Point Position => position;

    public void Move()
    {
        position.X += 10;
        position.Y += 10;
    }
}

class CarForm : Form
{
    private PictureBox pictureBox;
    private ICar car;

    public CarForm(ICar car)
    {
        this.car = car;
        this.Text = "샘플";
        this.Width = 300;
        this.Height = 200;

        pictureBox = new PictureBox
        {
            Image = car.Image,
            Left = car.Position.X,
            Top = car.Position.Y,
            Parent = this
        };
    }

    public void UpdateCarPosition()
    {
        car.Move();
        pictureBox.Left = car.Position.X;
        pictureBox.Top = car.Position.Y;
    }
}

class Program
{
    public static void Main()
    {
        ICar car = new Car("c:\\car.bmp");
        CarForm form = new CarForm(car);
        form.UpdateCarPosition();
        form.UpdateCarPosition();

        Application.Run(form);
    }
}
