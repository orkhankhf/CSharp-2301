using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User
            {
                Id= 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Username = "a",
                Password = "a"
            });

            Users.Add(new User
            {
                Id = 2,
                Name = "Ruslan",
                Surname = "Hesenov",
                Username = "ruslanhesenov",
                Password = "ruslan123456"
            });

            Users.Add(new User
            {
                Id = 3,
                Name = "Teymur",
                Surname = "Recebli",
                Username = "teymurrecebli",
                Password = "teymur123456"
            });
        }
    }
}
