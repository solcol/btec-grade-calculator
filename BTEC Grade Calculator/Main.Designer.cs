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
            this.sliderPass = new System.Windows.Forms.TrackBar();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDist = new System.Windows.Forms.Label();
            this.sliderDist = new System.Windows.Forms.TrackBar();
            this.labelMerit = new System.Windows.Forms.Label();
            this.sliderMerit = new System.Windows.Forms.TrackBar();
            this.gradeOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPoints = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPass)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMerit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderPass
            // 
            this.sliderPass.Location = new System.Drawing.Point(9, 43);
            this.sliderPass.Maximum = 18;
            this.sliderPass.Name = "sliderPass";
            this.sliderPass.Size = new System.Drawing.Size(428, 45);
            this.sliderPass.TabIndex = 0;
            this.sliderPass.ValueChanged += new System.EventHandler(this.passScrolled);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 27);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(30, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Pass";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDist);
            this.groupBox1.Controls.Add(this.sliderDist);
            this.groupBox1.Controls.Add(this.labelMerit);
            this.groupBox1.Controls.Add(this.sliderMerit);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.sliderPass);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units at Grade";
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Location = new System.Drawing.Point(6, 129);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(56, 13);
            this.labelDist.TabIndex = 5;
            this.labelDist.Text = "Distinction";
            // 
            // sliderDist
            // 
            this.sliderDist.Location = new System.Drawing.Point(9, 145);
            this.sliderDist.Maximum = 18;
            this.sliderDist.Name = "sliderDist";
            this.sliderDist.Size = new System.Drawing.Size(428, 45);
            this.sliderDist.TabIndex = 4;
            this.sliderDist.ValueChanged += new System.EventHandler(this.distScrolled);
            // 
            // labelMerit
            // 
            this.labelMerit.AutoSize = true;
            this.labelMerit.Location = new System.Drawing.Point(6, 78);
            this.labelMerit.Name = "labelMerit";
            this.labelMerit.Size = new System.Drawing.Size(30, 13);
            this.labelMerit.TabIndex = 3;
            this.labelMerit.Text = "Merit";
            // 
            // sliderMerit
            // 
            this.sliderMerit.Location = new System.Drawing.Point(9, 94);
            this.sliderMerit.Maximum = 18;
            this.sliderMerit.Name = "sliderMerit";
            this.sliderMerit.Size = new System.Drawing.Size(428, 45);
            this.sliderMerit.TabIndex = 2;
            this.sliderMerit.ValueChanged += new System.EventHandler(this.meritScrolled);
            // 
            // gradeOutput
            // 
            this.gradeOutput.BackColor = System.Drawing.SystemColors.Control;
            this.gradeOutput.Location = new System.Drawing.Point(91, 231);
            this.gradeOutput.Name = "gradeOutput";
            this.gradeOutput.ReadOnly = true;
            this.gradeOutput.Size = new System.Drawing.Size(367, 20);
            this.gradeOutput.TabIndex = 3;
            this.gradeOutput.Text = "FAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Grade:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.statusUnits,
            this.statusPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceCodeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 20);
            this.toolStripDropDownButton1.Text = "Program";
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceClick);
            // 
            // aboutToolStripMenuItem
            // 
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 315);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sliderPass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderMerit)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.TrackBar sliderDist;
        private System.Windows.Forms.Label labelMerit;
        private System.Windows.Forms.TrackBar sliderMerit;
        private System.Windows.Forms.TextBox gradeOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUnits;
        private System.Windows.Forms.ToolStripStatusLabel statusPoints;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

