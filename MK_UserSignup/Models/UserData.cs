using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MK_UserSignup.Models
{
    public class UserData
    {
        private static List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }
        public static void Add (User user)
        {
            users.Add(user);
        }

        public static User GetById(int id)
        {
            return users.Single(x => x.UserId == id);
        }

    }
}
