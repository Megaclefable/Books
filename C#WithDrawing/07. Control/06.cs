/*

Welcome!                     Car is selected            Truck is back to normal status.
                         ->                         ->
[ ] Car, [ ] Truck           [v] Car, [ ] Truck          [  ] Car, [ ] Truck


Cast :

public vold cb_CheckedChanged(Object sender, EventArgs e)
{
  CheckBox tmp = (CheckBox)sender ;   // Object class object type change to CheckBox
}

*/
  
  
using System;
using System.Windows.Forms;

class Sample6 : Form
{
    private Label lb;
    private CheckBox cb1, cb2;
    private FlowLayoutPanel flp;
 
    public static void Main()
    {
        Application.Run(new Sample6());
    }
    public Sample6()
    {
        this.Text = "Sample";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "Welcome";
        lb.Dock = DockStyle.Top;

        cb1 = new CheckBox();
        cb2 = new CheckBox();

        cb1.Text = "Car";
        cb2.Text = "Truck";

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Bottom;
        
        cb1.Parent = flp;
        cb2.Parent = flp;

        lb.Parent = this; 
        flp.Parent = this;

        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);
        cb2.CheckedChanged += new EventHandler(cb_CheckedChanged);
    }
    public void cb_CheckedChanged(Object sender, EventArgs e)
    {
        CheckBox tmp = (CheckBox)sender;
        if(tmp.Checked == true)
        {
            lb.Text =  tmp.Text + "is choosen";
        }
        else if (tmp.Checked == false)
        {
            lb.Text = tmp.Text + "is back to normal status";
        }
    }
}
