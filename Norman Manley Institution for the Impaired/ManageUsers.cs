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
    public partial class ManageUsers : Form
    {
        private readonly Norman_Manley_Institution_fo_the_ImpairedEntities1 ManageData;
        
        public ManageUsers()
        {
            InitializeComponent();
            ManageData = new Norman_Manley_Institution_fo_the_ImpairedEntities1();
            
        }


        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = ManageData.Users
                .Select(k => new
                {
                    k.id,
                    k.UserName,
                    k.UserRoles.FirstOrDefault().Role.Name,
                    k.isActive
                })
                .ToList();
            dgvManageUsers.DataSource = users;
            dgvManageUsers.Columns["isActive"].HeaderText = "Active";
            dgvManageUsers.Columns[0].Visible = false;




        }


        private void bAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void bResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;
                var user = ManageData.Users.FirstOrDefault(k => k.id == id);              
                var hashed_password = Utils.DefaultPassword();
                user.Password = hashed_password;
                ManageData.SaveChanges();

                MessageBox.Show($"{user.UserName}'s Password has been reset!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;
                var user = ManageData.Users.FirstOrDefault(k => k.id == id);
                user.isActive = user.isActive == true ? false : true;
                ManageData.SaveChanges();

                MessageBox.Show($"{user.UserName}'s active status has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

      
    }
}
