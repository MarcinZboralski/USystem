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
        public UserPerision UserPerision = new UserPerision();

    }

    [Serializable]
    public class UserPerision
    {
        public bool CreateUsers = false;
    }
}
