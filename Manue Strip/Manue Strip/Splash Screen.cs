using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manue_Strip
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login_Form form = new Login_Form ();
                form.ShowDialog();
            }
        
    }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
