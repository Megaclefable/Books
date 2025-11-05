/* 

    Welcome!       ->   Thank you! 
  [Purchase]           [Purchase - disabled]

*/


using System;
using System.Windows.Forms;

class Sample5 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample5());
    }
    public Sample5()
    {
        this.Text = "Sample";
        this.Width = 250; this.Height = 100;

        lb = new Label();
        lb.Text = "Welcome";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "Purchase";
        bt.Dock = DockStyle.Bottom;

        bt.Click += new EventHandler(bt_Click);

        lb.Parent = this;
        bt.Parent = this;
    }
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "Thank you for purchasing";
        bt.Enabled = false;
    }
}
