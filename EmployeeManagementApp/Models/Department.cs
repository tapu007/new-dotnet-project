using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee>Employees { get; set; }
        public  string Code { get; set; }
        public int Pnone { get; set; }



    }
}
