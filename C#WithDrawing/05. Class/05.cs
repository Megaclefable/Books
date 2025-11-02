/*

Make the form with interface.

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
