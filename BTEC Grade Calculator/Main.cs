using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTEC_Grade_Calculator
{

    public partial class Main : Form
    {
        bool shownTooManyUnitsWarning = false;
        public Main()
        {
            InitializeComponent();
        }


        private void calculateGrades()
        {
            string finalGrade = "FAIL";
            int passPoints = sliderPass.Value * 70;
            int meritPoints = sliderMerit.Value * 80;
            int distPoints = sliderDist.Value * 90;
            int totalPoints = passPoints + meritPoints + distPoints;

            statusPoints.Text = $"{totalPoints} Points";

            if (totalPoints < 1260) { finalGrade = "FAIL"; }
            else if (totalPoints >= 1260 && totalPoints < 1300) { finalGrade = "Pass Pass Pass"; }
            else if (totalPoints >= 1300 && totalPoints < 1340) { finalGrade = "Merit Pass Pass"; }
            else if (totalPoints >= 1340 && totalPoints < 1380) { finalGrade = "Merit Merit Pass"; }
            else if (totalPoints >= 1380 && totalPoints < 1420) { finalGrade = "Merit Merit Merit"; }
            else if (totalPoints >= 1420 && totalPoints < 1460) { finalGrade = "Dist Merit Merit"; }
            else if (totalPoints >= 1460 && totalPoints < 1500) { finalGrade = "Dist Dist Merit"; }
            else if (totalPoints >= 1500 && totalPoints < 1530) { finalGrade = "Dist Dist Dist"; }
            else if (totalPoints >= 1530 && totalPoints < 1560) { finalGrade = "Dist* Dist Dist"; }
            else if (totalPoints >= 1560 && totalPoints < 1590) { finalGrade = "Dist* Dist* Dist"; }
            else if (totalPoints >= 1590) { finalGrade = "Dist* Dist* Dist*"; }

            gradeOutput.Text = finalGrade;
        }
        private void onScroll()
        {
            int unitsInputted = sliderPass.Value + sliderMerit.Value + sliderDist.Value;

            statusUnits.Text = $"{unitsInputted}/18 Units";


            if (unitsInputted > 18)
            {
                statusUnits.ForeColor = Color.Red;

                if(shownTooManyUnitsWarning != true)
                {
                    MessageBox.Show("You have selected more than 18 total units. I won't tell you this again, but please be aware that you may have entered incorrect information.", "Hold on there matey!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    shownTooManyUnitsWarning = true;
                }
            } else
            {
                statusUnits.ForeColor = SystemColors.ControlText;
            }

            calculateGrades();
        }

        private void passScrolled(object sender, EventArgs e)
        {
            onScroll();
            labelPass.Text = $"Pass ({sliderPass.Value})";
        }

        private void meritScrolled(object sender, EventArgs e)
        {
            onScroll();
            labelMerit.Text = $"Merit ({sliderMerit.Value})";
        }

        private void distScrolled(object sender, EventArgs e)
        {
            onScroll();
            labelDist.Text = $"Dist ({sliderDist.Value})";
        }

        private void aboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("2022 SolCol.ThomasR.me\n\n" +
                            "Unit 6, Assignment 2\n\n" +
                            "Additional thanks to George and David.\nIcons from Icons8.",
                            "About this Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sourceClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itsmeimtom/solcol-btecgradecalculator");
        }
    }
}
