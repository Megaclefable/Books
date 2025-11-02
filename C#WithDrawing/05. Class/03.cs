/*
Efficient initialization for declared object 
include this in construct

public void Reset()
{
    top = 0;
    left = 0;
    img = Image.FromFile("c:\\car.bmp");
}


*/

using System.Windows.Forms;
using System.Drawing;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 250; fm.Height = 100;

        Label lb = new Label();

        Car c1 = new Car();
        Car c2 = new Car();

        lb.Width = 170;
        lb.Text = Car.CountCar();

        lb.Parent = fm;

        Application.Run(fm);
    }
}

class Car
{   
    /*static : every object share this value.   c1. c2. etc.. 

    static = can be called without an object
    
    1) It can be used immediately without creating an object
    2) It provides a shared space that belongs to the class rather than each instance
    
    */
    public static int Count = 0;
    private Image img;
    private int top;
    private int left;

    public Car()
    {
        Count++;
        img = Image.FromFile("c:\\car.bmp");
        top = 0;
        left = 0;
    }
    public static string CountCar()
    {
        return "how many cars? " + Count + "!";
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
    }
    public int Top
    {
        set { top = value; }
        get { return top; }
    }
    public int Left
    {
        set { left = value; }
        get { return left; }
    }
}
