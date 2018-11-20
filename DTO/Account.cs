using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public Account(string username, string password, int type)
        {
            Username = username;
            Password = password;
            Type = type;
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
