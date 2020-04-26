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
    public partial class MainWindow : Form
    {
        private Ulogin Login;
        public String _RoleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Ulogin login, User user)
        {
            InitializeComponent();
            Login = login;
            _user = user;
            _RoleName = user.UserRoles.FirstOrDefault().Role.Shortname;
        }


        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(k => k.Name == "ManageStudentData");
            if (!isOpen)
            {
                var studentinformation = new ManageStudentData();
                studentinformation.MdiParent = this;
                studentinformation.Show();
            }

           
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this.MdiParent;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.Password == Utils.DefaultPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            var username = _user.UserName;
            tsiLoginText.Text = $"Logged In As: {username}";
            if(_RoleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
