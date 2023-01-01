using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleynaOzmen_180201811_Project.Models
{
    public class Department
    {
        [PrimaryKey, AutoIncrement]
        public int Dept_id { get; set; }
        public string Dept_name { get; set; }

    }
}