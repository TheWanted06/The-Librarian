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
        public string Username { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }

        public User(string Fname, string Sname, string username)
        {
            this.FirstName = Fname;
            this.Surname = Sname;
            this.Username = username;
            Level = 0;
            Score = 0;
        }
        public User()
        {
            this.FirstName = null;
            this.Surname = null;
            this.Score = 0;
            this.Level = 0;
        }
    }
}
