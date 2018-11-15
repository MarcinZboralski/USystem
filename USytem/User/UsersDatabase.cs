using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USytem.User
{
    public class UsersDatabase
    {
        public static List<User> Users = new List<User>();

        public static void CreateAdmin()
        {
            User user = new User();

            user.Login = "admin";
            user.Password = "admin";

            user.UserPerision.CreateUsers = true;

            Users.Add(user);
        }

        public static bool CheckUser(string login, string password)
        {
            bool value = false;

            foreach (var v in Users)
            {
                if (v.Login == login && v.Password == password)
                {
                    value = true;
                    break;
                }
            }

            return value;
        }

        public static User GetTargetUser(string login, string password)
        {
            User value = new User();
            foreach (var v in Users)
            {
                if (v.Login == login && v.Password == password)
                {
                    value = v;
                    break;
                }
            }

            return value;
        }

        public static User CreateUser(string login,string password)
        {
            User user = new User();

            user.Login = login;
            user.Password = password;

            Users.Add(user);
            return user;
        }
    }
}
