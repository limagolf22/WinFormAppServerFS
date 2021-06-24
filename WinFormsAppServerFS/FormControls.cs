using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppServerFS
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        public void SetRudderValue(float v)
        {
            trackBarRudder.Value = (int)(v*100);
            if (Math.Abs(v*100) > 1)
            {
                trackBarRudder.BackColor = Color.Red; 
            }
            else
            {
                // trackBarRudder.BackColor = System.Drawing.SystemColors.Control;
                trackBarRudder.BackColor = Color.LimeGreen;
            }
            return;
        }

        public void SetSideSlipValue(float ssv)
        {
            int percent = (int)(ssv * 100 / 20);
            trackBarSideSlip.Value = percent;
            if (Math.Abs(percent) > 25)
            {
                trackBarSideSlip.BackColor = Color.Yellow;
            }
            else
            {
                trackBarSideSlip.BackColor = Color.LimeGreen;
            }
        }
    }
}
