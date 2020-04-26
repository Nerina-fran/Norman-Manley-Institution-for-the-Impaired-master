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
    public partial class ResetPassword : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
            _user = user;
        }

        private void bResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbNewPassword.Text;
                var confirm_password = tbconfirmpassword.Text;
                var user = ManageData.Users.FirstOrDefault(k => k.id == _user.id);
                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }

                user.Password = Utils.HashPassword(password);
                ManageData.SaveChanges();
                MessageBox.Show("Password was reset successfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Password's do not match. Please try again");
                
            }
        }
    }
}
