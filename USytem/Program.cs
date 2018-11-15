using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using USytem.User;
using USytem.WIndows;

namespace USytem
{
    static class Program
    {
        public static User.User CurrentUser;

        public static USystem USystem;
        public static ControlerWindow ControlerWindow;
        public static UserCreatorWindow UserCreatorWindow;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsersDatabase.CreateAdmin();
            UsersDatabase.CreateUser("rem","123");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Init();

            Application.Run(USystem);
        }

        private static void Init()
        {
            USystem = new USystem();
            ControlerWindow = new ControlerWindow();
            UserCreatorWindow = new UserCreatorWindow();
        }

        public static void Logout()
        {
            if (CurrentUser != new User.User())
            {
                ControlerWindow.Hide();
                USystem.Show();
                USystem.PasswordLabel.Text = null;
                CurrentUser = new User.User();
            }
        }
    }
}
