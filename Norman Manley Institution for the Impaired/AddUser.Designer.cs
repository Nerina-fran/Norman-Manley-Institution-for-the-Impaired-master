namespace Norman_Manley_Institution_for_the_Impaired
{
    partial class AddUser
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
            this.lAddUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LRole = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lAddUser
            // 
            this.lAddUser.AutoSize = true;
            this.lAddUser.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddUser.Location = new System.Drawing.Point(157, 9);
            this.lAddUser.Name = "lAddUser";
            this.lAddUser.Size = new System.Drawing.Size(231, 54);
            this.lAddUser.TabIndex = 2;
            this.lAddUser.Text = "Add User";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LRole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRoles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBUserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(78, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 208);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // LRole
            // 
            this.LRole.AutoSize = true;
            this.LRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRole.Location = new System.Drawing.Point(3, 104);
            this.LRole.Name = "LRole";
            this.LRole.Size = new System.Drawing.Size(42, 20);
            this.LRole.TabIndex = 2;
            this.LRole.Text = "Role";
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(3, 0);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(83, 20);
            this.LbUserName.TabIndex = 0;
            this.LbUserName.Text = "Username";
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(191, 107);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(182, 21);
            this.cbRoles.TabIndex = 3;
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(191, 3);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(182, 20);
            this.TBUserName.TabIndex = 1;
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.Location = new System.Drawing.Point(78, 293);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(114, 65);
            this.bSubmit.TabIndex = 4;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(336, 293);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(118, 59);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 390);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lAddUser);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LRole;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button BCancel;
    }
}