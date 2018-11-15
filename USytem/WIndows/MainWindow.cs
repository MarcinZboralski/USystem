using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using USytem.User;

namespace USytem.WIndows
{
    public partial class USystem : Form
    {

        public USystem()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        //Login
        private void button1_Click(object sender, EventArgs e)
        {
            if (UsersDatabase.CheckUser(textBox1.Text, PasswordLabel.Text))
            {
                Program.CurrentUser = UsersDatabase.GetTargetUser(textBox1.Text, PasswordLabel.Text);
                Program.ControlerWindow.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Account Dont Exist");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
