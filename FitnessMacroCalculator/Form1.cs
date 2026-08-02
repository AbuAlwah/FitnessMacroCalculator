using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessMacroCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbActivity.SelectedIndex = 0;
            cmbGoal.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Parse text inputs to numbers
            if (double.TryParse(txtWeight.Text, out double weight) &&
                double.TryParse(txtHeight.Text, out double height) &&
                double.TryParse(txtAge.Text, out double age))
            {
                // Display a confirmation message if parsing succeeds
                MessageBox.Show($"Data read successfully!\nWeight: {weight}\nHeight: {height}\nAge: {age}", "Success");
            }
            else
            {
                // Display an error message if any field is empty or invalid
                MessageBox.Show("Please enter valid numbers in all fields!", "Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
