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
    public partial class AddUser : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
            _manageUsers = manageUsers;
        }
       
        //ignore this field
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = ManageData.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.ValueMember = "id";
            cbRoles.DisplayMember = "Name";
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = TBUserName.Text;
                var RoleId = (int)cbRoles.SelectedValue;
                var password = Utils.DefaultPassword();
                var user = new User
                {
                    UserName = username,
                    Password = password,
                    isActive = true,
                };
                ManageData.Users.Add(user);
                ManageData.SaveChanges();

                var userid = user.id;
                var userRole = new UserRole
                {
                    Roleid = RoleId,
                    Userid = userid
                };
                ManageData.UserRoles.Add(userRole);
                ManageData.SaveChanges();
                
                MessageBox.Show("New User Added Succefully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
               MessageBox.Show("An error has occured"); 
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
