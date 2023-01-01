using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleynaOzmen_180201811_Project.Models
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }

        public int Emp_age { get; set; }


        public int Dept_id { get; set; }
    }
}