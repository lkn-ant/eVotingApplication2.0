﻿namespace eVoting_Application
{
    partial class VoterRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterRegistration));
            this.cbxYearOfStudy = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxInitials = new System.Windows.Forms.TextBox();
            this.lblYearOfStudy = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblInitials = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewElection = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblElecID = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.cbxFaculty = new System.Windows.Forms.ComboBox();
            this.btnFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxYearOfStudy
            // 
            this.cbxYearOfStudy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYearOfStudy.FormattingEnabled = true;
            this.cbxYearOfStudy.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year",
            "5th Year",
            "Postgraduate",
            "Other"});
            this.cbxYearOfStudy.Location = new System.Drawing.Point(166, 299);
            this.cbxYearOfStudy.Name = "cbxYearOfStudy";
            this.cbxYearOfStudy.Size = new System.Drawing.Size(307, 26);
            this.cbxYearOfStudy.TabIndex = 6;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbxGender.Location = new System.Drawing.Point(166, 267);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(306, 26);
            this.cbxGender.TabIndex = 5;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.Location = new System.Drawing.Point(166, 234);
            this.tbxAge.MaxLength = 2;
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(307, 27);
            this.tbxAge.TabIndex = 4;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(166, 168);
            this.tbxLastName.MaxLength = 45;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(307, 27);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxInitials
            // 
            this.tbxInitials.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInitials.Location = new System.Drawing.Point(166, 135);
            this.tbxInitials.MaxLength = 5;
            this.tbxInitials.Name = "tbxInitials";
            this.tbxInitials.Size = new System.Drawing.Size(307, 27);
            this.tbxInitials.TabIndex = 1;
            // 
            // lblYearOfStudy
            // 
            this.lblYearOfStudy.AutoSize = true;
            this.lblYearOfStudy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearOfStudy.Location = new System.Drawing.Point(12, 299);
            this.lblYearOfStudy.Name = "lblYearOfStudy";
            this.lblYearOfStudy.Size = new System.Drawing.Size(121, 18);
            this.lblYearOfStudy.TabIndex = 7;
            this.lblYearOfStudy.Text = "Year Of Study";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 267);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 18);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 234);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 18);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(12, 201);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(65, 18);
            this.lblFaculty.TabIndex = 10;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 168);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 18);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitials.Location = new System.Drawing.Point(12, 135);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(66, 18);
            this.lblInitials.TabIndex = 12;
            this.lblInitials.Text = "Initials";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eVoting_Application.Properties.Resources.Nust_Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewElection
            // 
            this.btnNewElection.Location = new System.Drawing.Point(322, 394);
            this.btnNewElection.Name = "btnNewElection";
            this.btnNewElection.Size = new System.Drawing.Size(150, 55);
            this.btnNewElection.TabIndex = 8;
            this.btnNewElection.Text = "Next";
            this.btnNewElection.UseVisualStyleBackColor = true;
            this.btnNewElection.Click += new System.EventHandler(this.btnNewElection_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(166, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 55);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblElecID
            // 
            this.lblElecID.AutoSize = true;
            this.lblElecID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElecID.Location = new System.Drawing.Point(12, 95);
            this.lblElecID.Name = "lblElecID";
            this.lblElecID.Size = new System.Drawing.Size(60, 18);
            this.lblElecID.TabIndex = 12;
            this.lblElecID.Text = "ElecID";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNum.Location = new System.Drawing.Point(363, 95);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(109, 18);
            this.lblStudentNum.TabIndex = 12;
            this.lblStudentNum.Text = "StudentNum";
            // 
            // cbxFaculty
            // 
            this.cbxFaculty.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFaculty.FormattingEnabled = true;
            this.cbxFaculty.Items.AddRange(new object[] {
            "Computing and Informatics",
            "Engineering",
            "Health and Applied Sciences",
            "Human Sciences",
            "Management Sciences",
            "Natural Resources and Spatial Sciences"});
            this.cbxFaculty.Location = new System.Drawing.Point(166, 202);
            this.cbxFaculty.Name = "cbxFaculty";
            this.cbxFaculty.Size = new System.Drawing.Size(306, 26);
            this.cbxFaculty.TabIndex = 3;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(322, 394);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(150, 55);
            this.btnFinished.TabIndex = 7;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // VoterRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.cbxFaculty);
            this.Controls.Add(this.btnNewElection);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxYearOfStudy);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxInitials);
            this.Controls.Add(this.lblYearOfStudy);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.lblElecID);
            this.Controls.Add(this.lblInitials);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VoterRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxYearOfStudy;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxInitials;
        private System.Windows.Forms.Label lblYearOfStudy;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewElection;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblElecID;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.ComboBox cbxFaculty;
        private System.Windows.Forms.Button btnFinished;
    }
}