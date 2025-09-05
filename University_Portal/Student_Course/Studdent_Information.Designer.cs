namespace Student_Course
{
    partial class Student_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Information));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentview)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(394, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 112);
            this.label8.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(521, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 53);
            this.label7.TabIndex = 52;
            this.label7.Text = "A.I.U.B (FST)";
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.Color.AliceBlue;
            this.back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2.Location = new System.Drawing.Point(1082, 588);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(151, 44);
            this.back2.TabIndex = 56;
            this.back2.Text = "Back";
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "View Students :";
            // 
            // studentview
            // 
            this.studentview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentview.Location = new System.Drawing.Point(39, 188);
            this.studentview.Name = "studentview";
            this.studentview.RowHeadersWidth = 51;
            this.studentview.RowTemplate.Height = 24;
            this.studentview.Size = new System.Drawing.Size(1194, 350);
            this.studentview.TabIndex = 54;
            // 
            // Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Student_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studdent_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_Information_FormClosing);
            this.Load += new System.EventHandler(this.Student_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentview;
    }
}