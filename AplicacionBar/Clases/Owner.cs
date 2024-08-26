using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Owner : Admin
    {
        public Owner(int id, string name, string lastName, string password) : base(id, name, lastName, password, EUser.owner)
        {
        }
    }
}
