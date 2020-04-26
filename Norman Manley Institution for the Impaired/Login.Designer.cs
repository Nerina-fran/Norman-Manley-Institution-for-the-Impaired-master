namespace Norman_Manley_Institution_for_the_Impaired
{
    partial class Ulogin
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
            this.LLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lUserName = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLogin.Location = new System.Drawing.Point(299, 9);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(148, 54);
            this.LLogin.TabIndex = 2;
            this.LLogin.Text = "Login";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(203, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 178);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(3, 0);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(85, 20);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "UserName";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(3, 89);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(78, 20);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(182, 3);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(173, 26);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(182, 92);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(173, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(264, 304);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(234, 47);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // Ulogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LLogin);
            this.Name = "Ulogin";
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button bLogin;
    }
}