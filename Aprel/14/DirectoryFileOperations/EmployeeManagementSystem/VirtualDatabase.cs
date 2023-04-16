using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public static class VirtualDatabase
    {
        public static int EmployeeIdentity = 1;
        public static BindingList<Employee> Employees { get; set; } = new BindingList<Employee>();
    }
}
