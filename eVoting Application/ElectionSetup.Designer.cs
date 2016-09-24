namespace eVoting_Application
{
    partial class ElectionSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectionSetup));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblElectionYear = new System.Windows.Forms.Label();
            this.lblNumOfCandidates = new System.Windows.Forms.Label();
            this.lblNumOfSRCMembers = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cbxNumOfSRCMembers = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbxNumOfCandidates = new System.Windows.Forms.ComboBox();
            this.cbxElectionYear = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.pbxNustLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNustLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 95);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NUST SRC Election WF Application";
            // 
            // lblElectionYear
            // 
            this.lblElectionYear.AutoSize = true;
            this.lblElectionYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionYear.Location = new System.Drawing.Point(9, 150);
            this.lblElectionYear.Name = "lblElectionYear";
            this.lblElectionYear.Size = new System.Drawing.Size(115, 18);
            this.lblElectionYear.TabIndex = 1;
            this.lblElectionYear.Text = "Election Year";
            // 
            // lblNumOfCandidates
            // 
            this.lblNumOfCandidates.AutoSize = true;
            this.lblNumOfCandidates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfCandidates.Location = new System.Drawing.Point(9, 182);
            this.lblNumOfCandidates.Name = "lblNumOfCandidates";
            this.lblNumOfCandidates.Size = new System.Drawing.Size(191, 18);
            this.lblNumOfCandidates.TabIndex = 1;
            this.lblNumOfCandidates.Text = "Number of Candidates";
            // 
            // lblNumOfSRCMembers
            // 
            this.lblNumOfSRCMembers.AutoSize = true;
            this.lblNumOfSRCMembers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfSRCMembers.Location = new System.Drawing.Point(9, 214);
            this.lblNumOfSRCMembers.Name = "lblNumOfSRCMembers";
            this.lblNumOfSRCMembers.Size = new System.Drawing.Size(210, 18);
            this.lblNumOfSRCMembers.TabIndex = 1;
            this.lblNumOfSRCMembers.Text = "Number of SRC Members";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(9, 247);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(164, 18);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Election Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(9, 280);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(154, 18);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "Election End Date";
            // 
            // cbxNumOfSRCMembers
            // 
            this.cbxNumOfSRCMembers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumOfSRCMembers.FormattingEnabled = true;
            this.cbxNumOfSRCMembers.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxNumOfSRCMembers.Location = new System.Drawing.Point(319, 206);
            this.cbxNumOfSRCMembers.Name = "cbxNumOfSRCMembers";
            this.cbxNumOfSRCMembers.Size = new System.Drawing.Size(150, 26);
            this.cbxNumOfSRCMembers.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(319, 238);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 27);
            this.dtpStartDate.TabIndex = 4;
            // 
            // cbxNumOfCandidates
            // 
            this.cbxNumOfCandidates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumOfCandidates.FormattingEnabled = true;
            this.cbxNumOfCandidates.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cbxNumOfCandidates.Location = new System.Drawing.Point(319, 174);
            this.cbxNumOfCandidates.Name = "cbxNumOfCandidates";
            this.cbxNumOfCandidates.Size = new System.Drawing.Size(150, 26);
            this.cbxNumOfCandidates.TabIndex = 2;
            // 
            // cbxElectionYear
            // 
            this.cbxElectionYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElectionYear.FormattingEnabled = true;
            this.cbxElectionYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbxElectionYear.Location = new System.Drawing.Point(319, 142);
            this.cbxElectionYear.Name = "cbxElectionYear";
            this.cbxElectionYear.Size = new System.Drawing.Size(150, 26);
            this.cbxElectionYear.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(319, 271);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 27);
            this.dtpEndDate.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(322, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 55);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pbxNustLogo
            // 
            this.pbxNustLogo.Image = global::eVoting_Application.Properties.Resources.Nust_Logo_2;
            this.pbxNustLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxNustLogo.Name = "pbxNustLogo";
            this.pbxNustLogo.Size = new System.Drawing.Size(460, 80);
            this.pbxNustLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNustLogo.TabIndex = 5;
            this.pbxNustLogo.TabStop = false;
            // 
            // ElectionSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pbxNustLogo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbxElectionYear);
            this.Controls.Add(this.cbxNumOfCandidates);
            this.Controls.Add(this.cbxNumOfSRCMembers);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblNumOfSRCMembers);
            this.Controls.Add(this.lblNumOfCandidates);
            this.Controls.Add(this.lblElectionYear);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElectionSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElectionSetup_FormClosing);
            this.Load += new System.EventHandler(this.ElectionSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNustLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblElectionYear;
        private System.Windows.Forms.Label lblNumOfCandidates;
        private System.Windows.Forms.Label lblNumOfSRCMembers;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cbxNumOfSRCMembers;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbxNumOfCandidates;
        private System.Windows.Forms.ComboBox cbxElectionYear;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbxNustLogo;
    }
}

