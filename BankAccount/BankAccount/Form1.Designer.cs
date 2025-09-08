namespace BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ownertext = new TextBox();
            button1 = new Button();
            Bankgrid = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            Amount = new NumericUpDown();
            label2 = new Label();
            interest = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Bankgrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)interest).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner : ";
            // 
            // ownertext
            // 
            ownertext.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ownertext.Location = new Point(155, 26);
            ownertext.Name = "ownertext";
            ownertext.Size = new Size(273, 43);
            ownertext.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(155, 181);
            button1.Name = "button1";
            button1.Size = new Size(273, 54);
            button1.TabIndex = 2;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bankgrid
            // 
            Bankgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Bankgrid.BackgroundColor = Color.FromArgb(224, 224, 224);
            Bankgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Bankgrid.Location = new Point(481, 26);
            Bankgrid.Name = "Bankgrid";
            Bankgrid.RowHeadersWidth = 51;
            Bankgrid.Size = new Size(576, 373);
            Bankgrid.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(481, 406);
            button2.Name = "button2";
            button2.Size = new Size(298, 59);
            button2.TabIndex = 5;
            button2.Text = "Deposite";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(797, 405);
            button3.Name = "button3";
            button3.Size = new Size(260, 59);
            button3.TabIndex = 6;
            button3.Text = "Withdraw";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 416);
            label3.Name = "label3";
            label3.Size = new Size(149, 38);
            label3.TabIndex = 8;
            label3.Text = "Amount : ";
            // 
            // Amount
            // 
            Amount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(155, 419);
            Amount.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            Amount.Minimum = new decimal(new int[] { 999999999, 0, 0, int.MinValue });
            Amount.Name = "Amount";
            Amount.Size = new Size(273, 38);
            Amount.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 10;
            label2.Text = "Interest : ";
            // 
            // interest
            // 
            interest.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interest.Location = new Point(155, 107);
            interest.Name = "interest";
            interest.Size = new Size(273, 43);
            interest.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 484);
            Controls.Add(interest);
            Controls.Add(label2);
            Controls.Add(Amount);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Bankgrid);
            Controls.Add(button1);
            Controls.Add(ownertext);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Bankgrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)interest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ownertext;
        private Button button1;
        private DataGridView Bankgrid;
        private Button button2;
        private Button button3;
        private Label label3;
        private NumericUpDown Amount;
        private Label label2;
        private NumericUpDown interest;
    }
}
