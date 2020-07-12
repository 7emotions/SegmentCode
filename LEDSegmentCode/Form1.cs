using System;
using System.Windows.Forms;

namespace LEDSegmentCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.anode.Checked = true;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if(this.cathode.Checked)
            {
                this.led1.SetOde(Ode.cathode);
            }
            else if(this.anode.Checked)
            {
                this.led1.SetOde(Ode.anode);
            }
            this.date.Text = "HexCode: " + this.led1.getHexCode();
        }
    }
}
