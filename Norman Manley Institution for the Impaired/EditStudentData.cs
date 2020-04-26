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
    public partial class EditStudentData : Form
    {
     
        private ManageStudentData managestudentdata;
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData; 

        public EditStudentData(DataforStudent editStudent, ManageStudentData manageStudentData = null)
        {
            InitializeComponent();
            lAddEdit.Text = "Edit Student";
            this.Text = "Edit Student";
            managestudentdata = manageStudentData;
            if(editStudent == null)
            {
                MessageBox.Show("Select a valid record to edit");
                Close();
            } 
            else
            {
                ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
                PopulateFields(editStudent);
            }
              
        }

        private void PopulateFields(DataforStudent Students)
        {
            LBid.Text = Students.id.ToString();
            tbstudentfname.Text = Students.StudentFName;
            tbstudentlname.Text = Students.StudentLName;
            tbnationality.Text = Students.Nationality;
            tbparentfname.Text = Students.ParentFirstName;
            tbparentlname.Text = Students.ParentLastName;
            tbaddress.Text = Students.Address;
            tbcontactnumber.Text = Students.ContactNumber;

        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            var id = int.Parse(LBid.Text);
            var Students = ManageData.DataforStudents.FirstOrDefault(k => k.id == id);
            Students.StudentFName = tbstudentfname.Text;
            Students.StudentLName = tbstudentlname.Text;
            Students.Nationality = tbnationality.Text;
            Students.ParentFirstName = tbparentfname.Text;
            Students.ParentLastName = tbparentlname.Text;
            Students.Address = tbaddress.Text;
            Students.ContactNumber = tbcontactnumber.Text;

            ManageData.SaveChanges();
            managestudentdata.populate();
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
