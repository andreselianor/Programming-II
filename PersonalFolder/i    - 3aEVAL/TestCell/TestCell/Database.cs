using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCell
{
    public class Database
    {
        public List<User> _users = new List<User>();

        public void CreateDB()
        {
            User u = new User();
            u.description = "Hombre serio y formal. Apasionado de su nuevo salón de cine";
            _users.Add(u);
        }
    }
}
