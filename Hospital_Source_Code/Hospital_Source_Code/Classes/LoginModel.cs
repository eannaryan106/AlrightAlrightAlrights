using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    class LoginModel
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public LoginModel() { }

        public LoginModel(string username, string password, int id, string userRole) {
            LoginId = id;
            Username = username;
            Password = password;
            UserType = userRole;
        }
    }
}
