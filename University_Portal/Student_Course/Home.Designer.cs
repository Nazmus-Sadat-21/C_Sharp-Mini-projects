namespace Student_Course
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminlogin = new System.Windows.Forms.Button();
            this.FacultyLogin = new System.Windows.Forms.Button();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(187, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "WHERE LEADERS ARE CREATED\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(289, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 120);
            this.label5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(159, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 50);
            this.label3.TabIndex = 14;
            this.label3.Text = "AMERICAN INTERNATIONAL\r\nUNIVERSITY- BANGLADESH\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminlogin
            // 
            this.adminlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adminlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminlogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.adminlogin.Location = new System.Drawing.Point(167, 265);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(354, 87);
            this.adminlogin.TabIndex = 17;
            this.adminlogin.Text = "Admid LogIn\r\n";
            this.adminlogin.UseVisualStyleBackColor = false;
            this.adminlogin.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // FacultyLogin
            // 
            this.FacultyLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FacultyLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacultyLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FacultyLogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FacultyLogin.Location = new System.Drawing.Point(167, 501);
            this.FacultyLogin.Name = "FacultyLogin";
            this.FacultyLogin.Size = new System.Drawing.Size(354, 87);
            this.FacultyLogin.TabIndex = 18;
            this.FacultyLogin.Text = "Faculty LogIn";
            this.FacultyLogin.UseVisualStyleBackColor = false;
            this.FacultyLogin.Click += new System.EventHandler(this.FacultyLogin_Click);
            // 
            // StudentLogin
            // 
            this.StudentLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StudentLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentLogin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.StudentLogin.Location = new System.Drawing.Point(167, 381);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(354, 87);
            this.StudentLogin.TabIndex = 19;
            this.StudentLogin.Text = "Student LogIn";
            this.StudentLogin.UseVisualStyleBackColor = false;
            this.StudentLogin.Click += new System.EventHandler(this.StudentLogin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 632);
            this.Controls.Add(this.StudentLogin);
            this.Controls.Add(this.FacultyLogin);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ForeColorChanged += new System.EventHandler(this.Home_ForeColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.Button FacultyLogin;
        private System.Windows.Forms.Button StudentLogin;
    }
}