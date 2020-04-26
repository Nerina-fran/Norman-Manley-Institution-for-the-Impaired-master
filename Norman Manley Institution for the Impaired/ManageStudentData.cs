using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norman_Manley_Institution_for_the_Impaired
{
    public partial class ManageStudentData : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;

        public ManageStudentData()
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
        }

        private void ManageStudentData_Load(object sender, EventArgs e)
        {

            try
            {
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void populate()
        {
            var Manage = ManageData.DataforStudents.Select(k => new
            {
                id = k.id,
                StudentsFName = k.StudentFName,
                StudentsLName = k.StudentLName,
                Nationality = k.Nationality,
                DateofBirth = k.DateofBirth,
                ParentFName = k.ParentFirstName,
                ParentLName = k.ParentLastName,
                Address = k.Address,
                Disability = k.DisabilityList.Name,
                Gender = k.StudentGender.Name,
                StudentsClass = k.ClassDetail.Name,
                ContactNumber = k.ContactNumber,
                ApplicationStatus = k.Status,
                EmailAddress = k.EmailAddress
            }).ToList();
            dgvManageSData.DataSource = Manage;
            dgvManageSData.Columns[0].Visible = false;

        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            
            
                var studentinformation = new StudentInformation();
                studentinformation.MdiParent = this.MdiParent;
                studentinformation.Show();
            
            
        }

        private void bUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvManageSData.SelectedRows[0].Cells["id"].Value;
                var Student = ManageData.DataforStudents.FirstOrDefault(k => k.id == id);
                
                var studentinformation = new EditStudentData(Student, this);
                studentinformation.MdiParent = this.MdiParent;
                studentinformation.Show();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
           
        }

        private void bDeleteInformation_Click(object sender, EventArgs e)
        {
            try 
            { 
                 var id = (int)dgvManageSData.SelectedRows[0].Cells["id"].Value;
                 var Student = ManageData.DataforStudents.FirstOrDefault(k => k.id == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                
                if(dr == DialogResult.Yes)
                {

                    ManageData.DataforStudents.Remove(Student);
                    ManageData.SaveChanges();

                }

                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
