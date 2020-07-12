using System;
using System.Drawing;
using System.Windows.Forms;

namespace LEDSegmentCode
{
    public partial class LED : UserControl
    {
        SegmentCode seg = new SegmentCode();
        Ode ode = Ode.anode;

        public LED()
        {
            InitializeComponent();
        }

        private void ClickProce(object sender,EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            if (pbox.BackColor.Equals(SystemColors.ControlDark))
            {
                pbox.BackColor = Color.Red;
                this.seg.dic[pbox.Name.ToCharArray()[0]] = 1;
            }
            else
            {
                pbox.BackColor = SystemColors.ControlDark;
                this.seg.dic[pbox.Name.ToCharArray()[0]] = 0;
            }
        }

        public String getHexCode()
        {
            seg.ode = this.ode;
            return seg.getCode();
        }

        public void SetOde(Ode ode)
        {
            this.ode = ode;
        }
    }
}
