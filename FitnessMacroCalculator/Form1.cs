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
                    MessageBox.Show("Please select your gender!", "Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                // 3. Determine Activity Multiplier from cmbActivity
                double activityMultiplier = 1.2; // Default Sedentary
                switch (cmbActivity.SelectedIndex)
                {
                    case 0: activityMultiplier = 1.2; break;   // Sedentary
                    case 1: activityMultiplier = 1.375; break; // Lightly Active
                    case 2: activityMultiplier = 1.55; break;  // Moderately Active
                    case 3: activityMultiplier = 1.725; break; // Very Active
                    case 4: activityMultiplier = 1.9; break;   // Extra Active
                }

                // 4. Calculate TDEE
                double tdee = bmr * activityMultiplier;

                // 5. Adjust calories according to cmbGoal
                double targetCalories = tdee;
                if (cmbGoal.SelectedIndex == 1)      // Cut / Weight Loss
                {
                    targetCalories -= 500;
                }
                else if (cmbGoal.SelectedIndex == 2) // Bulk / Muscle Gain
                {
                    targetCalories += 400;
                }

                // 6. Calculate Macros Breakdown
                // Protein: 2g per kg | Fats: 1g per kg | Carbs: Remaining calories / 4
                double protein = weight * 2.0;
                double fats = weight * 1.0;

                double proteinCalories = protein * 4;
                double fatsCalories = fats * 9;
                double remainingCalories = targetCalories - (proteinCalories + fatsCalories);
                double carbs = remainingCalories > 0 ? (remainingCalories / 4) : 0;

                // 7. Display Results in UI Labels
                lblBmrResult.Text = $"{Math.Round(bmr)}";
                lblTdeeResult.Text = $"{Math.Round(targetCalories)}";
                lblProteinResult.Text = $"{Math.Round(protein, 1)} g";
                lblCarbsResult.Text = $"{Math.Round(carbs, 1)} g";
                lblFatsResult.Text = $"{Math.Round(fats, 1)} g";
            }

            else
            {
                MessageBox.Show("Please enter valid numbers in all fields!", "Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
