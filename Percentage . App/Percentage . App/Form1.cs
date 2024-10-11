using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percentage.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            // Get total marks from the user input
            if (!double.TryParse(textBoxTotalMarks.Text, out double totalMarks) || totalMarks <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for total marks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get obtained marks from the user input
            if (!double.TryParse(textBoxObtainedMarks.Text, out double obtainedMarks) || obtainedMarks < 0 || obtainedMarks > totalMarks)
            {
                MessageBox.Show($"Please enter a valid number of marks obtained (0 - {totalMarks}).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate percentage
            double percentage = (obtainedMarks / totalMarks) * 100;

            // Determine grade
            string grade;
            if (percentage >= 90)
            {
                grade = "A";
            }
            else if (percentage >= 80)
            {
                grade = "B";
            }
            else if (percentage >= 70)
            {
                grade = "C";
            }
            else if (percentage >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            // Display the result
            labelResult.Text = $"You scored: {obtainedMarks}/{totalMarks}\nPercentage: {percentage:F2}%\nGrade: {grade}";
        }
    }
    }

