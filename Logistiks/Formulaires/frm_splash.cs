using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistiks.Formulaires
{
    public partial class frm_splash : Form
    {
        int count = 0, buffer = 0;
        public frm_splash()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                if(Opacity==0.30)
                {
                    pictureBox5.Show();
                }
                count++;
                Opacity = count * 0.10;
                pictureBox5.Show();                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {            
            if (buffer == 30)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Hide();                
                timer3.Stop();
                timer3.Enabled = false;
                timer3.Dispose();
                var m = new frm_admin();
                m.Show();
            }
            else
            {
                count--;
                Opacity = count * 0.10;
                
            }
        }
    }
}
