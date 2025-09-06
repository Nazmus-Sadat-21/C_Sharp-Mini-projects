namespace Flight_Ticket_booking
{
    partial class Payment
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
            acc = new TextBox();
            label8 = new Label();
            pin = new TextBox();
            label1 = new Label();
            pay2 = new Button();
            heading = new Label();
            SuspendLayout();
            // 
            // acc
            // 
            acc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acc.Location = new Point(221, 112);
            acc.Name = "acc";
            acc.Size = new Size(282, 34);
            acc.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(59, 112);
            label8.Name = "label8";
            label8.Size = new Size(153, 31);
            label8.TabIndex = 16;
            label8.Text = "Account No :";
            // 
            // pin
            // 
            pin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pin.Location = new Point(221, 181);
            pin.Name = "pin";
            pin.Size = new Size(282, 34);
            pin.TabIndex = 19;
            pin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 181);
            label1.Name = "label1";
            label1.Size = new Size(65, 31);
            label1.TabIndex = 18;
            label1.Text = "PIN :";
            // 
            // pay2
            // 
            pay2.BackColor = Color.FromArgb(0, 192, 0);
            pay2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pay2.ForeColor = SystemColors.ButtonHighlight;
            pay2.Location = new Point(221, 245);
            pay2.Name = "pay2";
            pay2.Size = new Size(282, 53);
            pay2.TabIndex = 20;
            pay2.Text = "Pay";
            pay2.UseVisualStyleBackColor = false;
            pay2.Click += pay2_Click;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading.Location = new Point(59, 42);
            heading.Name = "heading";
            heading.Size = new Size(141, 46);
            heading.TabIndex = 21;
            heading.Text = "Bkash : ";
            heading.Click += label2_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 356);
            Controls.Add(heading);
            Controls.Add(pay2);
            Controls.Add(pin);
            Controls.Add(label1);
            Controls.Add(acc);
            Controls.Add(label8);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox acc;
        private Label label8;
        private TextBox pin;
        private Label label1;
        private Button pay2;
        private Label heading;
    }
}