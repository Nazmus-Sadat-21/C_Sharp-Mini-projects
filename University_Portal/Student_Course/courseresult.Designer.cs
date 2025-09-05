namespace Student_Course
{
    partial class courseresult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseresult));
            this.n = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseview3 = new System.Windows.Forms.DataGridView();
            this.back2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cgpa = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseview3)).BeginInit();
            this.SuspendLayout();
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(158, 165);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(34, 29);
            this.n.TabIndex = 35;
            this.n.Text = "...";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(556, 165);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(34, 29);
            this.i.TabIndex = 34;
            this.i.Text = "...";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(916, 168);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(27, 29);
            this.c.TabIndex = 33;
            this.c.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(807, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Credit : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "View Course and Result: ";
            // 
            // courseview3
            // 
            this.courseview3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseview3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseview3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.courseview3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseview3.Location = new System.Drawing.Point(48, 279);
            this.courseview3.Name = "courseview3";
            this.courseview3.ReadOnly = true;
            this.courseview3.RowHeadersWidth = 51;
            this.courseview3.RowTemplate.Height = 24;
            this.courseview3.Size = new System.Drawing.Size(964, 276);
            this.courseview3.TabIndex = 36;
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.Color.AliceBlue;
            this.back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2.Location = new System.Drawing.Point(907, 694);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(105, 39);
            this.back2.TabIndex = 38;
            this.back2.Text = "Back";
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(309, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 112);
            this.label8.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(436, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 53);
            this.label7.TabIndex = 39;
            this.label7.Text = "A.I.U.B (FST)";
            // 
            // cgpa
            // 
            this.cgpa.AutoSize = true;
            this.cgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa.Location = new System.Drawing.Point(158, 588);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(34, 29);
            this.cgpa.TabIndex = 42;
            this.cgpa.Text = "...";
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.Location = new System.Drawing.Point(42, 588);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(123, 32);
            this.de.TabIndex = 41;
            this.de.Text = "CGPA : ";
            // 
            // courseresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 761);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.de);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseview3);
            this.Controls.Add(this.n);
            this.Controls.Add(this.i);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "courseresult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course and Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.courseresult_FormClosing);
            this.Load += new System.EventHandler(this.courseresult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseview3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView courseview3;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cgpa;
        private System.Windows.Forms.Label de;
    }
}