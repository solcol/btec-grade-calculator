namespace BTEC_Grade_Calculator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gradeOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.forecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forecastYes = new System.Windows.Forms.ToolStripMenuItem();
            this.forecastNo = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.sliderMerit = new System.Windows.Forms.TrackBar();
            this.sliderPass = new System.Windows.Forms.TrackBar();
            this.sliderDist = new System.Windows.Forms.TrackBar();
            this.labelDist = new System.Windows.Forms.Label();
            this.labelMerit = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDist)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeOutput
            // 
            this.gradeOutput.BackColor = System.Drawing.SystemColors.Control;
            this.gradeOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradeOutput.Location = new System.Drawing.Point(0, 193);
            this.gradeOutput.Multiline = true;
            this.gradeOutput.Name = "gradeOutput";
            this.gradeOutput.ReadOnly = true;
            this.gradeOutput.Size = new System.Drawing.Size(234, 43);
            this.gradeOutput.TabIndex = 3;
            this.gradeOutput.Text = "Hmm";
            this.gradeOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.statusUnits,
            this.statusPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(234, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forecastToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::BTEC_Grade_Calculator.Properties.Resources.icons8_info_16;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "Program";
            // 
            // forecastToolStripMenuItem
            // 
            this.forecastToolStripMenuItem.CheckOnClick = true;
            this.forecastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forecastYes,
            this.forecastNo});
            this.forecastToolStripMenuItem.Image = global::BTEC_Grade_Calculator.Properties.Resources.icons8_year_of_horse_16;
            this.forecastToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forecastToolStripMenuItem.Name = "forecastToolStripMenuItem";
            this.forecastToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.forecastToolStripMenuItem.Text = "Forecast?";
            // 
            // forecastYes
            // 
            this.forecastYes.Name = "forecastYes";
            this.forecastYes.Size = new System.Drawing.Size(91, 22);
            this.forecastYes.Text = "Yes";
            this.forecastYes.Click += new System.EventHandler(this.forecastYesClick);
            // 
            // forecastNo
            // 
            this.forecastNo.Name = "forecastNo";
            this.forecastNo.Size = new System.Drawing.Size(91, 22);
            this.forecastNo.Text = "No";
            this.forecastNo.Click += new System.EventHandler(this.forecastNoClick);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Image = global::BTEC_Grade_Calculator.Properties.Resources.icons8_code_16;
            this.sourceCodeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::BTEC_Grade_Calculator.Properties.Resources.icons8_about_16;
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutClick);
            // 
            // statusUnits
            // 
            this.statusUnits.Name = "statusUnits";
            this.statusUnits.Size = new System.Drawing.Size(43, 17);
            this.statusUnits.Text = "0 Units";
            // 
            // statusPoints
            // 
            this.statusPoints.Name = "statusPoints";
            this.statusPoints.Size = new System.Drawing.Size(49, 17);
            this.statusPoints.Text = "0 Points";
            // 
            // sliderMerit
            // 
            this.sliderMerit.AutoSize = false;
            this.sliderMerit.BackColor = System.Drawing.SystemColors.Control;
            this.sliderMerit.LargeChange = 1;
            this.sliderMerit.Location = new System.Drawing.Point(0, 76);
            this.sliderMerit.Maximum = 18;
            this.sliderMerit.Name = "sliderMerit";
            this.sliderMerit.Size = new System.Drawing.Size(234, 45);
            this.sliderMerit.TabIndex = 2;
            this.sliderMerit.ValueChanged += new System.EventHandler(this.meritScrolled);
            // 
            // sliderPass
            // 
            this.sliderPass.AutoSize = false;
            this.sliderPass.BackColor = System.Drawing.SystemColors.Control;
            this.sliderPass.LargeChange = 1;
            this.sliderPass.Location = new System.Drawing.Point(0, 17);
            this.sliderPass.Maximum = 18;
            this.sliderPass.Name = "sliderPass";
            this.sliderPass.Size = new System.Drawing.Size(234, 45);
            this.sliderPass.TabIndex = 0;
            this.sliderPass.ValueChanged += new System.EventHandler(this.passScrolled);
            // 
            // sliderDist
            // 
            this.sliderDist.AutoSize = false;
            this.sliderDist.BackColor = System.Drawing.SystemColors.Control;
            this.sliderDist.LargeChange = 1;
            this.sliderDist.Location = new System.Drawing.Point(0, 132);
            this.sliderDist.Maximum = 18;
            this.sliderDist.Name = "sliderDist";
            this.sliderDist.Size = new System.Drawing.Size(234, 45);
            this.sliderDist.TabIndex = 4;
            this.sliderDist.ValueChanged += new System.EventHandler(this.distScrolled);
            // 
            // labelDist
            // 
            this.labelDist.BackColor = System.Drawing.Color.Gold;
            this.labelDist.Location = new System.Drawing.Point(0, 114);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(234, 15);
            this.labelDist.TabIndex = 5;
            this.labelDist.Text = "Distinction";
            this.labelDist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMerit
            // 
            this.labelMerit.BackColor = System.Drawing.Color.Silver;
            this.labelMerit.Location = new System.Drawing.Point(0, 55);
            this.labelMerit.Name = "labelMerit";
            this.labelMerit.Size = new System.Drawing.Size(234, 15);
            this.labelMerit.TabIndex = 6;
            this.labelMerit.Text = "Merit";
            this.labelMerit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPass
            // 
            this.labelPass.BackColor = System.Drawing.Color.BurlyWood;
            this.labelPass.Location = new System.Drawing.Point(0, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(234, 14);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Pass";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMerit);
            this.Controls.Add(this.labelDist);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sliderMerit);
            this.Controls.Add(this.sliderDist);
            this.Controls.Add(this.gradeOutput);
            this.Controls.Add(this.sliderPass);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grades";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gradeOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUnits;
        private System.Windows.Forms.ToolStripStatusLabel statusPoints;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar sliderMerit;
        private System.Windows.Forms.TrackBar sliderPass;
        private System.Windows.Forms.TrackBar sliderDist;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.Label labelMerit;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.ToolStripMenuItem forecastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forecastYes;
        private System.Windows.Forms.ToolStripMenuItem forecastNo;
    }
}

