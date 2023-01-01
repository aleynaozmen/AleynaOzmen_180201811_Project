using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleynaOzmen_180201811_Project.Models
{
    public class Project
    {
        [PrimaryKey, AutoIncrement]
        public int Project_id { get; internal set; }
        public string Project_name { get; set; }

    }
}