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
                // 2. Check gender selection and calculate BMR
                double bmr = 0;

                if (rdoMale.Checked)
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                }
                else if (rdoFemale.Checked)
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                }
                else
                {
                    MessageBox.Show("Please select your gender!", "Input Error");
                    return;
                }

                // 3. Display the calculated BMR
                MessageBox.Show($"Your BMR is: {bmr:F0} kcal/day", "BMR Result");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in all fields!", "Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
