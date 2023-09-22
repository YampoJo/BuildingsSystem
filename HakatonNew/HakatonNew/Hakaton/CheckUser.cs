using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakaton
{
    public class CheckUser
    {
        public string Login { get; set; }

        public bool IsAdmin { get; set; }

        public string Status => IsAdmin ? "Admin" : "User";

        public CheckUser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
