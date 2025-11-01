using System.Windows.Forms;
using System.Drawing;

class Sample1 
{ 
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 300; fm.Height = 200; 

        PictureBox pb = new PictureBox();
        
        Car c = new Car();
        c.Move();
        c.Move();

        pb.Image = c.img;
        pb.Top = c.top;
        pb.Left = c.left;

        /*
        Application
              → Form (window)
                   → Controls
                        → Button / PictureBox / Label ...
        */
        pb.Parent = fm; //Same with : fm.Controls.Add(pb);

        Application.Run(fm);
    }
}
class Car
{
    public Image img;
    public int top;
    public int left;
    public Car()
    {
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top+10;
        left = left+10;
    }
}
