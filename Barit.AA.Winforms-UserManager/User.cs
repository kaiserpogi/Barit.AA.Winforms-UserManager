using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barit.AA.Winforms_UserManager
{
    public class User
    {
       
        public User(string fullName, string username, string password)
        {
            this.FullName = fullName;
            this.Username = username;
            this.Password = password;
        }
        public int Id { get; set; }
        public string FullName { get;  set; }
        public string Username { get; set; }
        public string Password { get; set; }



    }
}
