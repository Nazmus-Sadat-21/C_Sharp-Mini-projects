namespace Library_Managment
{
    partial class Main_Page
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
            this.label3 = new System.Windows.Forms.Label();
            this.Booklist = new System.Windows.Forms.DataGridView();
            this.SelectedBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.borrow = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Booklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Book List";
            // 
            // Booklist
            // 
            this.Booklist.AllowUserToAddRows = false;
            this.Booklist.AllowUserToDeleteRows = false;
            this.Booklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Booklist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Booklist.GridColor = System.Drawing.SystemColors.Control;
            this.Booklist.Location = new System.Drawing.Point(32, 136);
            this.Booklist.Name = "Booklist";
            this.Booklist.ReadOnly = true;
            this.Booklist.RowHeadersWidth = 51;
            this.Booklist.RowTemplate.Height = 24;
            this.Booklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Booklist.Size = new System.Drawing.Size(914, 291);
            this.Booklist.TabIndex = 12;
            this.Booklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Booklist_CellClick);
            // 
            // SelectedBook
            // 
            this.SelectedBook.AllowUserToAddRows = false;
            this.SelectedBook.AllowUserToDeleteRows = false;
            this.SelectedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedBook.GridColor = System.Drawing.SystemColors.Control;
            this.SelectedBook.Location = new System.Drawing.Point(41, 569);
            this.SelectedBook.MultiSelect = false;
            this.SelectedBook.Name = "SelectedBook";
            this.SelectedBook.ReadOnly = true;
            this.SelectedBook.RowHeadersWidth = 51;
            this.SelectedBook.RowTemplate.Height = 24;
            this.SelectedBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedBook.Size = new System.Drawing.Size(748, 291);
            this.SelectedBook.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selected Book";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove.Location = new System.Drawing.Point(810, 607);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(136, 43);
            this.remove.TabIndex = 15;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // borrow
            // 
            this.borrow.BackColor = System.Drawing.Color.Green;
            this.borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrow.Location = new System.Drawing.Point(810, 691);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(136, 43);
            this.borrow.TabIndex = 16;
            this.borrow.Text = "Borrow";
            this.borrow.UseVisualStyleBackColor = false;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Navy;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(810, 778);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(136, 43);
            this.close.TabIndex = 17;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Ivory;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(32, 446);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(133, 43);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Heading
            // 
            this.Heading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(32, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(914, 51);
            this.Heading.TabIndex = 20;
            this.Heading.Text = "Welcome,Name";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 894);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.add);
            this.Controls.Add(this.close);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedBook);
            this.Controls.Add(this.Booklist);
            this.Controls.Add(this.label3);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Page_FormClosing);
            this.Load += new System.EventHandler(this.Main_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Booklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Booklist;
        private System.Windows.Forms.DataGridView SelectedBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label Heading;
    }
}