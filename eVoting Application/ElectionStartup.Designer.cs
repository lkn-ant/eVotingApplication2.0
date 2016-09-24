namespace eVoting_Application
{
    partial class ElectionStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectionStartup));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoadElection = new System.Windows.Forms.Button();
            this.btnNewElection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(10, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 55);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLoadElection
            // 
            this.btnLoadElection.Location = new System.Drawing.Point(166, 141);
            this.btnLoadElection.Name = "btnLoadElection";
            this.btnLoadElection.Size = new System.Drawing.Size(150, 55);
            this.btnLoadElection.TabIndex = 5;
            this.btnLoadElection.Text = "Load Election";
            this.btnLoadElection.UseVisualStyleBackColor = true;
            // 
            // btnNewElection
            // 
            this.btnNewElection.Location = new System.Drawing.Point(320, 141);
            this.btnNewElection.Name = "btnNewElection";
            this.btnNewElection.Size = new System.Drawing.Size(150, 55);
            this.btnNewElection.TabIndex = 5;
            this.btnNewElection.Text = "New Election";
            this.btnNewElection.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eVoting_Application.Properties.Resources.Nust_Logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ElectionStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewElection);
            this.Controls.Add(this.btnLoadElection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElectionStartup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectionStartup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadElection;
        private System.Windows.Forms.Button btnNewElection;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}