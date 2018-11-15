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
            if (Program.CurrentUser.UserPerision.CreateUsers)
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
            Program.Logout();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
