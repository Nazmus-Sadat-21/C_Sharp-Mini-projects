namespace Student_Course
{
    partial class StudentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPortal));
            this.coursereg = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.Button();
            this.course_result = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.logout2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursereg
            // 
            this.coursereg.BackColor = System.Drawing.Color.RoyalBlue;
            this.coursereg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coursereg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursereg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coursereg.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.coursereg.Location = new System.Drawing.Point(419, 247);
            this.coursereg.Name = "coursereg";
            this.coursereg.Size = new System.Drawing.Size(354, 87);
            this.coursereg.TabIndex = 22;
            this.coursereg.Text = "Course Registration";
            this.coursereg.UseVisualStyleBackColor = false;
            this.coursereg.Click += new System.EventHandler(this.coursereg_Click);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.RoyalBlue;
            this.reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.reg.Location = new System.Drawing.Point(34, 400);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(354, 87);
            this.reg.TabIndex = 21;
            this.reg.Text = "Registration";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // studentInfo
            // 
            this.studentInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.studentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentInfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.studentInfo.Location = new System.Drawing.Point(34, 247);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(354, 87);
            this.studentInfo.TabIndex = 20;
            this.studentInfo.Text = "Information";
            this.studentInfo.UseVisualStyleBackColor = false;
            this.studentInfo.Click += new System.EventHandler(this.studentInfo_Click);
            // 
            // course_result
            // 
            this.course_result.BackColor = System.Drawing.Color.RoyalBlue;
            this.course_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.course_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.course_result.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.course_result.Location = new System.Drawing.Point(419, 400);
            this.course_result.Name = "course_result";
            this.course_result.Size = new System.Drawing.Size(354, 87);
            this.course_result.TabIndex = 23;
            this.course_result.Text = "Course and Result\r\n";
            this.course_result.UseVisualStyleBackColor = false;
            this.course_result.Click += new System.EventHandler(this.course_result_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(344, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 120);
            this.label5.TabIndex = 25;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heading.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.RoyalBlue;
            this.heading.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.heading.Location = new System.Drawing.Point(158, 150);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(507, 45);
            this.heading.TabIndex = 24;
            this.heading.Text = "Welcome MD Nazmus Sadat\r\n";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logout2
            // 
            this.logout2.BackColor = System.Drawing.Color.White;
            this.logout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logout2.Location = new System.Drawing.Point(607, 511);
            this.logout2.Name = "logout2";
            this.logout2.Size = new System.Drawing.Size(166, 52);
            this.logout2.TabIndex = 31;
            this.logout2.Text = "LogOut";
            this.logout2.UseVisualStyleBackColor = false;
            this.logout2.Click += new System.EventHandler(this.logout2_Click);
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 585);
            this.Controls.Add(this.logout2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.course_result);
            this.Controls.Add(this.coursereg);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.studentInfo);
            this.Name = "StudentPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPortal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPortal_FormClosing);
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coursereg;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Button studentInfo;
        private System.Windows.Forms.Button course_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button logout2;
    }
}