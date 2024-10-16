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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;


            string correctEmail = "sahoon@gmail.com";
            string correctPassword = "12345";


            if (email == correctEmail && password == correctPassword)
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
    }

        private void Login_Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
