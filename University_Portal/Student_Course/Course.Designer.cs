namespace Student_Course
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.courseview = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.confrim = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.id1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseview)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(38, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 244);
            this.listBox1.TabIndex = 0;
            // 
            // courseview
            // 
            this.courseview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.courseview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseview.Location = new System.Drawing.Point(38, 622);
            this.courseview.Name = "courseview";
            this.courseview.RowHeadersWidth = 51;
            this.courseview.RowTemplate.Height = 24;
            this.courseview.Size = new System.Drawing.Size(964, 255);
            this.courseview.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(635, 304);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(367, 244);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Course : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected Course :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credit : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(165, 148);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 32);
            this.name.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(546, 151);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 29);
            this.id.TabIndex = 11;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(906, 142);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(27, 29);
            this.credit.TabIndex = 12;
            this.credit.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(424, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 53);
            this.label7.TabIndex = 13;
            this.label7.Text = "A.I.U.B (FST)";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.AliceBlue;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(446, 304);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(145, 49);
            this.add.TabIndex = 14;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // confrim
            // 
            this.confrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confrim.Location = new System.Drawing.Point(446, 499);
            this.confrim.Name = "confrim";
            this.confrim.Size = new System.Drawing.Size(145, 49);
            this.confrim.TabIndex = 15;
            this.confrim.Text = "Confrim";
            this.confrim.UseVisualStyleBackColor = false;
            this.confrim.Click += new System.EventHandler(this.confrim_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove.Location = new System.Drawing.Point(446, 401);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(145, 49);
            this.remove.TabIndex = 16;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(298, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 112);
            this.label8.TabIndex = 17;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.AliceBlue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(897, 884);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(105, 39);
            this.logout.TabIndex = 18;
            this.logout.Text = "Back";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id1.Location = new System.Drawing.Point(546, 139);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(34, 29);
            this.id1.TabIndex = 19;
            this.id1.Text = "...";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(148, 139);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(34, 29);
            this.name1.TabIndex = 20;
            this.name1.Text = "...";
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(38, 216);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(356, 30);
            this.search.TabIndex = 21;
            this.search.Text = " ";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(400, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 938);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.confrim);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.courseview);
            this.Controls.Add(this.listBox1);
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Course_FormClosing);
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView courseview;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button confrim;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
    }
}