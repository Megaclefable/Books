using System;
using System.Windows.Forms;

class Sample4 : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample4());
    }
    public Sample4()
    {
        this.Text = "Sample";
        this.Width = 250; this.Height = 100;

        lb1 = new Label();
        lb1.Text = "Choose it with Arrow key(SK key)";
        lb1.Width = this.Width;

        lb2 = new Label();
        lb2.Top = lb1.Bottom;

        lb1.Parent = this;
        lb2.Parent = this;

        this.KeyDown += new KeyEventHandler(fm_KeyDown);

    }
    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        String str;
        if(e.KeyCode == Keys.Up)
        {
           str = "up";
        }
        else if(e.KeyCode == Keys.Down)
        {
           str = "down";
        }
        else if(e.KeyCode == Keys.Right)
        {
           str = "right";
        }
        else if(e.KeyCode == Keys.Left)
        {
           str = "left";
        }
        else
        {
           str = "other key";
        }
        lb2.Text = str + "is pressed.";
    }
}
