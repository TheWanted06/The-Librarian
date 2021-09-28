using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Librarian
{
    public class User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }
        public string Username { get; set; }
        public string password { get; set; }

        public User(string Fname, string Sname, string username, string email, string password)
        {
            this.FirstName = Fname;
            this.Surname = Sname;
            this.Username = username;
            this.email = email;
            this.password = password;
        }
    }
}
