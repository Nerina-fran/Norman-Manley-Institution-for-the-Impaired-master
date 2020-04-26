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
    public partial class StudentInformation : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 norman_Manley_Institution_Fo_the_ImpairedEntities1;
        public StudentInformation()
        {
            InitializeComponent();
            norman_Manley_Institution_Fo_the_ImpairedEntities1 = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
        }


        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                var studentsfname = tbStudentsFName.Text;
                var studentslname = tbStudentsLName.Text;
                var Nationality = tbNationality.Text;
                var DateofBirth = dtpDateOfBirth.Value;
                var disability = cbDisability.Text;
                var Gender = cbGender.Text;
                var Class = cbClass.Text;
                var parentsfname = tbParentsFName.Text;
                var parentslname = tbParentsLName.Text;
                var contactnumber = tbContactNumber.Text;
                var address = tbAddress.Text;
                var EmailAddress = tbEmailAddress.Text;
                var status = tbStatus.Text;

                var isValid = true;

                if (string.IsNullOrWhiteSpace(studentsfname) || string.IsNullOrWhiteSpace(studentslname))
                {
                    isValid = false;
                    MessageBox.Show("All fields are required");
                }

                if (isValid == true)
                {
                    var StudentData = new DataforStudent();
                    StudentData.StudentFName = studentsfname;
                    StudentData.StudentLName = studentslname;
                    StudentData.Nationality = Nationality;
                    StudentData.DateofBirth = DateofBirth;
                    StudentData.ParentFirstName = parentsfname;
                    StudentData.ParentLastName = parentslname;
                    StudentData.ContactNumber = contactnumber;
                    StudentData.Address = address;
                    StudentData.Status = status;
                    StudentData.Disabilityid = (int)cbDisability.SelectedValue;
                    StudentData.StudentGenderid = (int)cbGender.SelectedValue;
                    StudentData.Classid = (int)cbClass.SelectedValue;

                    norman_Manley_Institution_Fo_the_ImpairedEntities1.DataforStudents.Add(StudentData);
                    norman_Manley_Institution_Fo_the_ImpairedEntities1.SaveChanges();

                   

                    MessageBox.Show($"Students First Name: {studentsfname}\n\r" +
                                    $"Students Last Name: {studentslname}\n\r"+
                                    $"Childs Nationality: {Nationality}\n\r" +
                                    $"Date of Birth: {DateofBirth}\n\r" +
                                    $"Childs Disability: {disability}\n\r" +
                                    $"Childs Gender: {Gender}\n\r" +
                                    $"Childs Class: {Class}\n\r" +
                                    $"Parents First Name: {parentsfname}\n\r"+
                                    $"Parents Last Name: {parentslname}\n\r"+
                                    $"Contact Number: {contactnumber}\n\r"+
                                    $"Parents Address: {address}\n\r"+
                                    $"Parents Email Address: {EmailAddress}\n\r"+
                                    $"Childs Status: {status}\n\r"+
                                    $"FILE WAS SAVED SUCCESSFULLY");
                    
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }


            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Classes = norman_Manley_Institution_Fo_the_ImpairedEntities1.ClassDetails.ToList();
            cbClass.DisplayMember = "Name";
            cbClass.ValueMember = "id";
            cbClass.DataSource = Classes;

            var gender = norman_Manley_Institution_Fo_the_ImpairedEntities1.StudentGenders.ToList();
            cbGender.DisplayMember = "Name";
            cbGender.ValueMember = "id";
            cbGender.DataSource = gender;

            var Disable = norman_Manley_Institution_Fo_the_ImpairedEntities1.DisabilityLists.ToList();
            cbDisability.DisplayMember = "Name";
            cbDisability.ValueMember = "id";
            cbDisability.DataSource = Disable;
             
        }
      
    }
}
