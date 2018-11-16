using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USytem.User
{
    public class User
    {
        public string Login;
        public string Password;
        public UserPermision UserPermision = new UserPermision();

    }

    [Serializable]
    public class UserPermision
    {
        public bool Admin = false;
        public bool CreateUsers = false;
        public bool Replenishment = false;
        public bool CreateOrders = false;
        public bool ChangeOrders = false;
        public bool Priority = false;
    }
}
