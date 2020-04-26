namespace Norman_Manley_Institution_for_the_Impaired
{
    partial class ManageUsers
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
            this.bResetPassword = new System.Windows.Forms.Button();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bDeactivateUser = new System.Windows.Forms.Button();
            this.dgvManageUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // bResetPassword
            // 
            this.bResetPassword.Location = new System.Drawing.Point(272, 312);
            this.bResetPassword.Name = "bResetPassword";
            this.bResetPassword.Size = new System.Drawing.Size(124, 54);
            this.bResetPassword.TabIndex = 12;
            this.bResetPassword.Text = "Reset Password";
            this.bResetPassword.UseVisualStyleBackColor = true;
            this.bResetPassword.Click += new System.EventHandler(this.bResetPassword_Click);
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(57, 312);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(138, 54);
            this.bAddUser.TabIndex = 11;
            this.bAddUser.Text = "Add User";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(156, 70);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(148, 37);
            this.bRefresh.TabIndex = 19;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Users";
            // 
            // bDeactivateUser
            // 
            this.bDeactivateUser.Location = new System.Drawing.Point(482, 312);
            this.bDeactivateUser.Name = "bDeactivateUser";
            this.bDeactivateUser.Size = new System.Drawing.Size(136, 54);
            this.bDeactivateUser.TabIndex = 17;
            this.bDeactivateUser.Text = "Deactivate/Activate User";
            this.bDeactivateUser.UseVisualStyleBackColor = true;
            this.bDeactivateUser.Click += new System.EventHandler(this.bDeactivateUser_Click);
            // 
            // dgvManageUsers
            // 
            this.dgvManageUsers.AllowUserToAddRows = false;
            this.dgvManageUsers.AllowUserToDeleteRows = false;
            this.dgvManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageUsers.Location = new System.Drawing.Point(156, 113);
            this.dgvManageUsers.Name = "dgvManageUsers";
            this.dgvManageUsers.ReadOnly = true;
            this.dgvManageUsers.Size = new System.Drawing.Size(342, 142);
            this.dgvManageUsers.TabIndex = 16;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeactivateUser);
            this.Controls.Add(this.dgvManageUsers);
            this.Controls.Add(this.bResetPassword);
            this.Controls.Add(this.bAddUser);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bResetPassword;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDeactivateUser;
        private System.Windows.Forms.DataGridView dgvManageUsers;
    }
}