using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norman_Manley_Institution_for_the_Impaired
{
    public partial class Ulogin : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;
        public Ulogin()
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                 
                var Username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.HashPassword(password);

                var user = ManageData.Users.FirstOrDefault(k => k.UserName == Username && k.Password == hashed_password
                           && k.isActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide correct credentials");
                }
                else
                {
                   
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide(); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went Wrong, Please try again"); 
            }
            

            
        }
    }
}
