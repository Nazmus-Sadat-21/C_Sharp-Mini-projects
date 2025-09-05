namespace Student_Course
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
            this.pin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pin
            // 
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(249, 274);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(337, 34);
            this.pin.TabIndex = 22;
            this.pin.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "PIN : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // accno
            // 
            this.accno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accno.Location = new System.Drawing.Point(249, 205);
            this.accno.Name = "accno";
            this.accno.Size = new System.Drawing.Size(337, 30);
            this.accno.TabIndex = 20;
            this.accno.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Account No : ";
            // 
            // method
            // 
            this.method.AutoSize = true;
            this.method.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method.ForeColor = System.Drawing.Color.RoyalBlue;
            this.method.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.method.Location = new System.Drawing.Point(76, 50);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(234, 49);
            this.method.TabIndex = 23;
            this.method.Text = "Visa Card :";
            this.method.Click += new System.EventHandler(this.method_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay.Location = new System.Drawing.Point(249, 338);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(337, 49);
            this.pay.TabIndex = 39;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(249, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 30);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Amount :";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.method);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accno);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label method;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}