namespace Norman_Manley_Institution_for_the_Impaired
{
    partial class ResetPassword
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
            this.lNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbconfirmpassword = new System.Windows.Forms.TextBox();
            this.bResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewPassword.Location = new System.Drawing.Point(126, 9);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(138, 17);
            this.lNewPassword.TabIndex = 0;
            this.lNewPassword.Text = "Enter New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(100, 39);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(191, 20);
            this.tbNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Password";
            // 
            // tbconfirmpassword
            // 
            this.tbconfirmpassword.Location = new System.Drawing.Point(100, 104);
            this.tbconfirmpassword.Name = "tbconfirmpassword";
            this.tbconfirmpassword.PasswordChar = '*';
            this.tbconfirmpassword.Size = new System.Drawing.Size(191, 20);
            this.tbconfirmpassword.TabIndex = 3;
            // 
            // bResetPassword
            // 
            this.bResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResetPassword.Location = new System.Drawing.Point(129, 155);
            this.bResetPassword.Name = "bResetPassword";
            this.bResetPassword.Size = new System.Drawing.Size(135, 43);
            this.bResetPassword.TabIndex = 4;
            this.bResetPassword.Text = "Reset Password";
            this.bResetPassword.UseVisualStyleBackColor = true;
            this.bResetPassword.Click += new System.EventHandler(this.bResetPassword_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 210);
            this.Controls.Add(this.bResetPassword);
            this.Controls.Add(this.tbconfirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lNewPassword);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbconfirmpassword;
        private System.Windows.Forms.Button bResetPassword;
    }
}