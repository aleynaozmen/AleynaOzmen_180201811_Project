using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleynaOzmen_180201811_Project.Models
{
    public class Assignment
    {
        [PrimaryKey, AutoIncrement]
        public int Assignment_id { get; set; }
        public int Emp_id { get; set; }
        public int Project_id { get; set; }
        public string Assignment_date { get; set; }
    }
}