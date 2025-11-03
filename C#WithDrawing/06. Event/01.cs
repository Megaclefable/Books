/*
Function :
If you click the form, the label will be chagned.

The delegate is already done in Forms :
public delegate void EventHandler(object sender, EventArgs e);
*/


using System;
using System.Windows.Forms;

class Sample1 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample1());
    }
    
    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 250; this.Height = 200;
     
        lb = new Label();
        lb.Text = "Welcome!";
        
        lb.Parent = this;

       
        this.Click += new EventHandler(fm_Click);
    }
    
    public void fm_Click(Object sender, EventArgs e)
    {
        lb.Text = "Hello";
    }
}
