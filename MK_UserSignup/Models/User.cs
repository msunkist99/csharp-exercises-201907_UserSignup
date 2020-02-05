using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MK_UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserId { get; }
        public DateTime CreateDateTime { get;  }

        private static int nextUserId = 0;

        public User()
        {
            UserId = ++nextUserId;
            CreateDateTime = DateTime.Now;
        }

    }
}
