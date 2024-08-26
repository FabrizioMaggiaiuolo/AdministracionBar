using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Employee : User
    {
        private EShifts workShift;
        public Employee(int id, string name, string lastName, string password, EShifts workShift) : base(id, name, lastName, password, EUser.employee)
        {
            this.workShift = workShift;
        }
    }
}
