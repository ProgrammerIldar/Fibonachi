using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonachi
{
    public partial class mainForms : Form
    {
        public mainForms()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 8;
            metroProgressBar1.Maximum = 100;
            metroProgressBar1.Value = 0;
        }

        private void MainForms_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(metroProgressBar1.Maximum==metroProgressBar1.Value)
            {
                timer1.Enabled = false;
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                metroProgressBar1.Value++;
            }
        }


        Point formLocation;
        Point mouseLocation;
        private void MainForms_MouseDown(object sender, MouseEventArgs e)
        {
            formLocation = this.Location;
            mouseLocation = e.Location;
        }

        private void MainForms_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Location != mouseLocation)
            {
                formLocation.X += (e.Location.X - mouseLocation.X);
                formLocation.Y += (e.Location.Y - mouseLocation.Y);
                this.Location = formLocation;
            }
        }
    }
}
