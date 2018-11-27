using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USytem.User;

namespace USytem.WIndows
{
    public partial class UserCreatorWindow : Form
    {

        public User.User TrUser;

        public UserCreatorWindow()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserCreatorWindow_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateAll()
        {
            UsersDatabase.Load();
            UpdateLeft();
        }

        public void UpdateLeft()
        {
            ListaLewa.Items.Clear();
            foreach (var v in UsersDatabase.Users)
            {
                ListViewItem it = new ListViewItem(v.Login);
                it.SubItems.Add(v.Password);
                ListaLewa.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrUser = UsersDatabase.GetTargetUser(SearcherUserTextField.Text);

            permLogin.Text = TrUser.Login;
            permPassword.Text = TrUser.Password;

            permAdmin.Checked = TrUser.UserPermision.Admin;
            permCreateUsers.Checked = TrUser.UserPermision.CreateUsers;
            permReplenishment.Checked = TrUser.UserPermision.Replenishment;
            permCreateOrders.Checked = TrUser.UserPermision.CreateOrders;
            permChangeOrders.Checked = TrUser.UserPermision.ChangeOrders;
            permPriority.Checked = TrUser.UserPermision.Priority;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            Program.ControlerWindow.Update();
            Hide();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            if (permLogin.Text == null || permPassword.Text == null)
            {
                return;
            }

            UsersDatabase.UpdateUser(SearcherUserTextField.Text, permLogin.Text, permPassword.Text,GetPermision());
            UsersDatabase.Save();
            UsersDatabase.Load();
            UpdateAll();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (permLogin.Text == null || permPassword.Text == null)
            {
                return;
            }

            UsersDatabase.CreateUser(permLogin.Text, permPassword.Text,GetPermision());
            UsersDatabase.Save();
            UsersDatabase.Load();
            UpdateAll();
        }

        private UserPermision GetPermision()
        {
            UserPermision prem = new UserPermision();

            prem.Admin = permAdmin.Checked;
            prem.CreateUsers = permCreateUsers.Checked;
            prem.Replenishment = permReplenishment.Checked;
            prem.CreateOrders = permCreateOrders.Checked;
            prem.ChangeOrders = permChangeOrders.Checked;
            prem.Priority = permPriority.Checked;

            return prem;
        }

        public void Clear()
        {
            SearcherUserTextField.Text = null;

            permLogin.Text = null;
            permPassword.Text = null;

            permAdmin.Checked = false;
            permCreateUsers.Checked = false;
            permReplenishment.Checked = false;
            permCreateOrders.Checked = false;
            permChangeOrders.Checked = false;
            permPriority.Checked = false;
        }

        private void SearcherUserTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            UsersDatabase.DeleteUser(SearcherUserTextField.Text);
            UpdateAll();
        }
    }
}
