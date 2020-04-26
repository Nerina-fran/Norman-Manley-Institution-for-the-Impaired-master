namespace Norman_Manley_Institution_for_the_Impaired
{
    partial class ManageStudentData
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
            this.dgvManageSData = new System.Windows.Forms.DataGridView();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.bUpdateInformation = new System.Windows.Forms.Button();
            this.bDeleteInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageSData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageSData
            // 
            this.dgvManageSData.AllowUserToAddRows = false;
            this.dgvManageSData.AllowUserToDeleteRows = false;
            this.dgvManageSData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageSData.Location = new System.Drawing.Point(12, 119);
            this.dgvManageSData.Name = "dgvManageSData";
            this.dgvManageSData.ReadOnly = true;
            this.dgvManageSData.Size = new System.Drawing.Size(1096, 225);
            this.dgvManageSData.TabIndex = 1;
            // 
            // bAddStudent
            // 
            this.bAddStudent.Location = new System.Drawing.Point(149, 371);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(115, 54);
            this.bAddStudent.TabIndex = 4;
            this.bAddStudent.Text = "Add Student";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // bUpdateInformation
            // 
            this.bUpdateInformation.Location = new System.Drawing.Point(497, 371);
            this.bUpdateInformation.Name = "bUpdateInformation";
            this.bUpdateInformation.Size = new System.Drawing.Size(115, 54);
            this.bUpdateInformation.TabIndex = 6;
            this.bUpdateInformation.Text = "Update Information";
            this.bUpdateInformation.UseVisualStyleBackColor = true;
            this.bUpdateInformation.Click += new System.EventHandler(this.bUpdateInformation_Click);
            // 
            // bDeleteInformation
            // 
            this.bDeleteInformation.Location = new System.Drawing.Point(826, 371);
            this.bDeleteInformation.Name = "bDeleteInformation";
            this.bDeleteInformation.Size = new System.Drawing.Size(115, 54);
            this.bDeleteInformation.TabIndex = 7;
            this.bDeleteInformation.Text = "Delete Information";
            this.bDeleteInformation.UseVisualStyleBackColor = true;
            this.bDeleteInformation.Click += new System.EventHandler(this.bDeleteInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Student Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(993, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeleteInformation);
            this.Controls.Add(this.bUpdateInformation);
            this.Controls.Add(this.bAddStudent);
            this.Controls.Add(this.dgvManageSData);
            this.Name = "ManageStudentData";
            this.Text = "Manage Student Data";
            this.Load += new System.EventHandler(this.ManageStudentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageSData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageSData;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.Button bUpdateInformation;
        private System.Windows.Forms.Button bDeleteInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}