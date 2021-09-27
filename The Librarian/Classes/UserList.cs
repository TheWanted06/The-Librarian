using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Librarian
{
    public class UserList<T>
    {
        //List<User> listOfUsers = new List<User>();
        public int UserId { get; set; }
        public User theUser { get; set; }
    }
}
