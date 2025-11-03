/*

if Purchase button is clicked, 
the showing label : Welcome! -> Thanks!

*/

using System;
using System.Windows.Forms;

class Sample2 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample2());
    }
    public Sample2()
    {
        this.Text = "Sample";
        this.Width = 250; 
        this.Height = 100;

        lb = new Label();
        lb.Text = "Welcome!";
        lb.Width = 150;
        
        bt = new Button();
        bt.Text = "Purchase";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;  
        
        bt.Click += new EventHandler(bt_Click);
    }

    /*
    public void bt_Click(Object sender, EventArgs e)
    {
    if (bt.Text == "Purchase")
    {
        lb.Text = "Purchased done, Thanks!";
        bt.Text = "Back to first page";
    }
    else if (bt.Text == "Back to first page")
    {
        lb.Text = "Welcome";
        bt.Text = "Purchase"
    */
    /*when clicked, this event happens */
    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "Thanks!";
    }
}
