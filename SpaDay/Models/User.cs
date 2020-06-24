using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set;  }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string username, string email, string password) : this()
        {
            Username = username;
            Email = email;
            Password = password;
        }

    }
}
