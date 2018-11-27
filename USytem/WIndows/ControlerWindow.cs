using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USytem.WIndows
{
    public partial class ControlerWindow : Form
    {
        public ControlerWindow()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.UserPermision.CreateUsers || Program.CurrentUser.UserPermision.Admin)
            {
                if (Program.UserCreatorWindow.Visible == false)
                {
                    Program.UserCreatorWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("You Dont Have Permison");
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.UserCreatorWindow.Clear();
            Program.Logout();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrdersPage_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ControlerWindow_Load(object sender, EventArgs e)
        {
            Update();
        }

        public void Update(bool first)
        {
            if (Program.CurrentUser.UserPermision.CreateOrders == false || Program.CurrentUser.UserPermision.ChangeOrders == false)
            {
                Zakładki.TabPages.Remove(OrdersPage);
            }
            else
            {
                if (!first)
                {
                    Zakładki.TabPages.Add(OrdersPage);
                }
            }
            Zakładki.Update();
        }

        private void TaskPage_Click(object sender, EventArgs e)
        {

        }
    }
}
