namespace eVoting_Application
{
    partial class Ballot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ballot));
            this.pbxNustLogo = new System.Windows.Forms.PictureBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnLoadBallot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxCandID = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFaculty = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxInitials = new System.Windows.Forms.TextBox();
            this.tbxNumSRC = new System.Windows.Forms.TextBox();
            this.tbxStudentNum = new System.Windows.Forms.TextBox();
            this.tbxStudentFaculty = new System.Windows.Forms.TextBox();
            this.tbxStudentGender = new System.Windows.Forms.TextBox();
            this.tbxElecId = new System.Windows.Forms.TextBox();
            this.tbxStudentYearOfStudy = new System.Windows.Forms.TextBox();
            this.tbxStudentAge = new System.Windows.Forms.TextBox();
            this.btnFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNustLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxNustLogo
            // 
            this.pbxNustLogo.Image = global::eVoting_Application.Properties.Resources.Nust_Logo_2;
            this.pbxNustLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxNustLogo.Name = "pbxNustLogo";
            this.pbxNustLogo.Size = new System.Drawing.Size(871, 80);
            this.pbxNustLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNustLogo.TabIndex = 6;
            this.pbxNustLogo.TabStop = false;
            // 
            // btnVote
            // 
            this.btnVote.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVote.Location = new System.Drawing.Point(577, 597);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(150, 33);
            this.btnVote.TabIndex = 70;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnLoadBallot
            // 
            this.btnLoadBallot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBallot.Location = new System.Drawing.Point(421, 597);
            this.btnLoadBallot.Name = "btnLoadBallot";
            this.btnLoadBallot.Size = new System.Drawing.Size(150, 33);
            this.btnLoadBallot.TabIndex = 70;
            this.btnLoadBallot.Text = "Load Ballot";
            this.btnLoadBallot.UseVisualStyleBackColor = true;
            this.btnLoadBallot.Click += new System.EventHandler(this.btnLoadBallot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(871, 411);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbxCandID
            // 
            this.tbxCandID.Location = new System.Drawing.Point(12, 516);
            this.tbxCandID.Name = "tbxCandID";
            this.tbxCandID.Size = new System.Drawing.Size(100, 20);
            this.tbxCandID.TabIndex = 73;
            this.tbxCandID.Visible = false;
            this.tbxCandID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(224, 516);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 73;
            this.tbxLastName.Visible = false;
            this.tbxLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxFaculty
            // 
            this.tbxFaculty.Location = new System.Drawing.Point(330, 516);
            this.tbxFaculty.Name = "tbxFaculty";
            this.tbxFaculty.Size = new System.Drawing.Size(100, 20);
            this.tbxFaculty.TabIndex = 73;
            this.tbxFaculty.Visible = false;
            this.tbxFaculty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(436, 516);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 73;
            this.tbxAge.Visible = false;
            this.tbxAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxInitials
            // 
            this.tbxInitials.Location = new System.Drawing.Point(118, 516);
            this.tbxInitials.Name = "tbxInitials";
            this.tbxInitials.Size = new System.Drawing.Size(100, 20);
            this.tbxInitials.TabIndex = 73;
            this.tbxInitials.Visible = false;
            this.tbxInitials.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxNumSRC
            // 
            this.tbxNumSRC.Location = new System.Drawing.Point(540, 516);
            this.tbxNumSRC.Name = "tbxNumSRC";
            this.tbxNumSRC.Size = new System.Drawing.Size(100, 20);
            this.tbxNumSRC.TabIndex = 73;
            this.tbxNumSRC.Visible = false;
            this.tbxNumSRC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStudentNum
            // 
            this.tbxStudentNum.Location = new System.Drawing.Point(118, 542);
            this.tbxStudentNum.Name = "tbxStudentNum";
            this.tbxStudentNum.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentNum.TabIndex = 73;
            this.tbxStudentNum.Visible = false;
            this.tbxStudentNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStudentFaculty
            // 
            this.tbxStudentFaculty.Location = new System.Drawing.Point(330, 542);
            this.tbxStudentFaculty.Name = "tbxStudentFaculty";
            this.tbxStudentFaculty.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentFaculty.TabIndex = 73;
            this.tbxStudentFaculty.Visible = false;
            this.tbxStudentFaculty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStudentGender
            // 
            this.tbxStudentGender.Location = new System.Drawing.Point(436, 542);
            this.tbxStudentGender.Name = "tbxStudentGender";
            this.tbxStudentGender.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentGender.TabIndex = 73;
            this.tbxStudentGender.Visible = false;
            this.tbxStudentGender.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxElecId
            // 
            this.tbxElecId.Location = new System.Drawing.Point(12, 542);
            this.tbxElecId.Name = "tbxElecId";
            this.tbxElecId.Size = new System.Drawing.Size(100, 20);
            this.tbxElecId.TabIndex = 73;
            this.tbxElecId.Visible = false;
            this.tbxElecId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStudentYearOfStudy
            // 
            this.tbxStudentYearOfStudy.Location = new System.Drawing.Point(540, 542);
            this.tbxStudentYearOfStudy.Name = "tbxStudentYearOfStudy";
            this.tbxStudentYearOfStudy.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentYearOfStudy.TabIndex = 73;
            this.tbxStudentYearOfStudy.Visible = false;
            this.tbxStudentYearOfStudy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxStudentAge
            // 
            this.tbxStudentAge.Location = new System.Drawing.Point(224, 542);
            this.tbxStudentAge.Name = "tbxStudentAge";
            this.tbxStudentAge.Size = new System.Drawing.Size(100, 20);
            this.tbxStudentAge.TabIndex = 73;
            this.tbxStudentAge.Visible = false;
            this.tbxStudentAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFinished
            // 
            this.btnFinished.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.Location = new System.Drawing.Point(733, 597);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(150, 33);
            this.btnFinished.TabIndex = 70;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // Ballot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(895, 642);
            this.Controls.Add(this.tbxStudentAge);
            this.Controls.Add(this.tbxInitials);
            this.Controls.Add(this.tbxStudentYearOfStudy);
            this.Controls.Add(this.tbxNumSRC);
            this.Controls.Add(this.tbxElecId);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxStudentGender);
            this.Controls.Add(this.tbxFaculty);
            this.Controls.Add(this.tbxStudentFaculty);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxStudentNum);
            this.Controls.Add(this.tbxCandID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadBallot);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.pbxNustLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ballot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ballot";
            this.Load += new System.EventHandler(this.Ballot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNustLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxNustLogo;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnLoadBallot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxCandID;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFaculty;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxInitials;
        private System.Windows.Forms.TextBox tbxNumSRC;
        private System.Windows.Forms.TextBox tbxStudentNum;
        private System.Windows.Forms.TextBox tbxStudentFaculty;
        private System.Windows.Forms.TextBox tbxStudentGender;
        private System.Windows.Forms.TextBox tbxElecId;
        private System.Windows.Forms.TextBox tbxStudentYearOfStudy;
        private System.Windows.Forms.TextBox tbxStudentAge;
        private System.Windows.Forms.Button btnFinished;
    }
}