namespace Student_Course
{
    partial class Admin_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Portal));
            this.logout2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.coursereg = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout2
            // 
            this.logout2.BackColor = System.Drawing.Color.White;
            this.logout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logout2.Location = new System.Drawing.Point(224, 464);
            this.logout2.Name = "logout2";
            this.logout2.Size = new System.Drawing.Size(354, 52);
            this.logout2.TabIndex = 36;
            this.logout2.Text = "LogOut";
            this.logout2.UseVisualStyleBackColor = false;
            this.logout2.Click += new System.EventHandler(this.logout2_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(342, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 120);
            this.label5.TabIndex = 35;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.RoyalBlue;
            this.heading.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.heading.Location = new System.Drawing.Point(250, 153);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(301, 45);
            this.heading.TabIndex = 34;
            this.heading.Text = "Welcome Admin\r\n";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coursereg
            // 
            this.coursereg.BackColor = System.Drawing.Color.RoyalBlue;
            this.coursereg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coursereg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursereg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coursereg.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.coursereg.Location = new System.Drawing.Point(224, 347);
            this.coursereg.Name = "coursereg";
            this.coursereg.Size = new System.Drawing.Size(354, 87);
            this.coursereg.TabIndex = 33;
            this.coursereg.Text = "Faculty Information\r\n";
            this.coursereg.UseVisualStyleBackColor = false;
            this.coursereg.Click += new System.EventHandler(this.coursereg_Click);
            // 
            // studentInfo
            // 
            this.studentInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.studentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.studentInfo.Location = new System.Drawing.Point(224, 231);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(354, 87);
            this.studentInfo.TabIndex = 32;
            this.studentInfo.Text = "Student Information";
            this.studentInfo.UseVisualStyleBackColor = false;
            this.studentInfo.Click += new System.EventHandler(this.studentInfo_Click);
            // 
            // Admin_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.Controls.Add(this.logout2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.coursereg);
            this.Controls.Add(this.studentInfo);
            this.Name = "Admin_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Portal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button coursereg;
        private System.Windows.Forms.Button studentInfo;
    }
}