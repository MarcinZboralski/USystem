﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using USytem.SaveData;

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

            user.UserPermision.CreateUsers = true;

            foreach (var v in Users)
            {
                if (v.Login == "admin")
                {
                    return;
                }
            }

            Users.Add(user);

            if (!File.Exists(Application.UserAppDataPath + "/Users.xml"))
            {
                Save();
            }
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

        public static void DeleteUser(string login)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Login == login)
                {
                    Users.RemoveAt(i);
                    Save();
                    MessageBox.Show(login + ": Has Been Deleted");
                    return;
                }
            }

            MessageBox.Show("Account With This Login Exist");
        }

        public static User CreateUser(string login,string password)
        {
            User user = new User();

            foreach (var v in Users)
            {
                if (v.Login == login)
                {
                    MessageBox.Show("Account With This Login Exist");
                    return null;
                }
            }

            user.Login = login;
            user.Password = password;

            Users.Add(user);
            return user;
        }

        public static User CreateUser(string login, string password,UserPermision permision)
        {
            User user = new User();

            foreach (var v in Users)
            {
                if (v.Login == login)
                {
                    MessageBox.Show("Account With This Login Exist");
                    return null;
                }
            }

            user.Login = login;
            user.Password = password;
            user.UserPermision = permision;

            Users.Add(user);
            return user;
        }

        public static User GetTargetUser(string targetLogin)
        {
            User u = new User();

            foreach (var v in Users)
            {
                if (v.Login == targetLogin)
                {
                    u = v;
                    break;
                }
            }

            if (string.IsNullOrEmpty(u.Login))
            {
                MessageBox.Show("Acount Dont Exist");
            }

            return u;
        }

        public static void UpdateUser(string targetLogin,string newLogin, string newPassword,UserPermision newUserPermison)
        {
            foreach (var v in Users)
            {
                if (v.Login == targetLogin)
                {
                    v.Login = newLogin;
                    v.Password = newPassword;
                    v.UserPermision = newUserPermison;
                    return;
                }
            }

            MessageBox.Show("User Not Found");
        }

        public static void Save()
        {
            SaveUsers.Save(Users);
        }

        public static void Load()
        {
            SaveUsers.Load(out Users);
        }

    }
}
