using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Admin : User
    {
        public Admin(int id, string name, string lastName, string password, EUser typeUser = EUser.admin) : base(id, name, lastName, password, typeUser)
        {
        }
    }
}
