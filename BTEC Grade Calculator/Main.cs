using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTEC_Grade_Calculator
{

    public partial class Main : Form
    {
        bool shownTooManyUnitsWarning = false;
        bool generateForecast = false;
        int unitsInputted = 0;
        public Main()
        {
            InitializeComponent();
        }


        private void calculateGrades()
        {
            string finalGrade = "Fail";
            int ucasPoints = 0;
            int passPoints = sliderPass.Value * 70;
            int meritPoints = sliderMerit.Value * 80;
            int distPoints = sliderDist.Value * 90;
            int totalPoints = passPoints + meritPoints + distPoints;

            statusPoints.Text = $"{totalPoints} Points";

            if(generateForecast && unitsInputted < 18 && unitsInputted > 0)
            {
                int currentAverage = totalPoints / unitsInputted;
                int assumedPoints = (18 - unitsInputted) * currentAverage;
                statusPoints.Text = $"{totalPoints} + {assumedPoints} Points";
                totalPoints += assumedPoints;
            }

            if (totalPoints < 1260) { finalGrade = "Fail"; ucasPoints = 0; }
            else if (totalPoints >= 1260 && totalPoints < 1300) { finalGrade = "Pass Pass Pass"; ucasPoints = 48; }
            else if (totalPoints >= 1300 && totalPoints < 1340) { finalGrade = "Merit Pass Pass"; ucasPoints = 64; }
            else if (totalPoints >= 1340 && totalPoints < 1380) { finalGrade = "Merit Merit Pass"; ucasPoints = 80; }
            else if (totalPoints >= 1380 && totalPoints < 1420) { finalGrade = "Merit Merit Merit"; ucasPoints = 96; }
            else if (totalPoints >= 1420 && totalPoints < 1460) { finalGrade = "Dist Merit Merit"; ucasPoints = 112; }
            else if (totalPoints >= 1460 && totalPoints < 1500) { finalGrade = "Dist Dist Merit"; ucasPoints = 128; }
            else if (totalPoints >= 1500 && totalPoints < 1530) { finalGrade = "Dist Dist Dist"; ucasPoints = 144; }
            else if (totalPoints >= 1530 && totalPoints < 1560) { finalGrade = "Dist* Dist Dist"; ucasPoints = 152; }
            else if (totalPoints >= 1560 && totalPoints < 1590) { finalGrade = "Dist* Dist* Dist"; ucasPoints = 160; }
            else if (totalPoints >= 1590) { finalGrade = "Dist* Dist* Dist*"; ucasPoints = 168; }

            finalGrade += $"{Environment.NewLine}{ucasPoints} UCAS";

            if(generateForecast && unitsInputted < 18)
            {
                gradeOutput.Text = $"{finalGrade}{Environment.NewLine}(forecast)";
            }
            else
            {
                gradeOutput.Text = finalGrade;
            }

        }
        private void onScroll()
        {
            unitsInputted = sliderPass.Value + sliderMerit.Value + sliderDist.Value;

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

        private void forecastYesClick(object sender, EventArgs e)
        {
            MessageBox.Show("Forecast grades are generated with the assumption that you will complete 18 total units, and will complete the remainder at smilar attainment.", "Just so you know", MessageBoxButtons.OK, MessageBoxIcon.Information);
            generateForecast = true;
            this.Text = "Grades (forecasting)";
            calculateGrades();
        }

        private void forecastNoClick(object sender, EventArgs e)
        {
            generateForecast = false;
            this.Text = "Grades";
            calculateGrades();
        }
    }
}
