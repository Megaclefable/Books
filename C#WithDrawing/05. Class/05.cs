/*

Make the form with interface.

We don't need to right all these :
Form fm = new Form();
fm.Text = "Sample";
Application.Run(fm);


*/

using System.Windows.Forms;
using System.Drawing;

class Sample5 : Form
{
    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public Sample5()
    {
        this.Text = "Sample";
        this.Width = 400; this.Height = 200;
        this.BackgroundImage = Image.FromFile("c:\\car.bmp");
    }
}
