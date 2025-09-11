namespace Library_Managment
{
    partial class SignUp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(64, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "SignUp";
            // 
            // UserPass
            // 
            this.UserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPass.Location = new System.Drawing.Point(64, 427);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(351, 28);
            this.UserPass.TabIndex = 9;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(64, 135);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(351, 28);
            this.UserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // UserEmail
            // 
            this.UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail.Location = new System.Drawing.Point(64, 234);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(351, 28);
            this.UserEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // UserPhone
            // 
            this.UserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPhone.Location = new System.Drawing.Point(64, 332);
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.Size = new System.Drawing.Size(351, 28);
            this.UserPhone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 573);
            this.Controls.Add(this.UserPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserPhone;
        private System.Windows.Forms.Label label5;
    }
}