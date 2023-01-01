using AleynaOzmen_180201811_Project.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AleynaOzmen_180201811_Project.DBTrans
{
    public class dBTransFixed
    {
        public string dbPath;
        private SQLiteConnection conn;

        public dBTransFixed(string _dbPath)
        {
            this.dbPath = _dbPath;
        }

        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);

            conn.CreateTable<Employee>();
            conn.CreateTable<Department>();
            conn.CreateTable<Assignment>();
            conn.CreateTable<Project>();
     

        }

        public List<Employee> GetAllEmployee()
        {
            Init();
            return conn.Table<Employee>().ToList();
        }
        public List<Assignment> GetAllAssignment()
        {
            Init();
            return conn.Table<Assignment>().ToList();
        }

        public List<Department> GetAllDepartment()
        {
            Init();
            return conn.Table<Department>().ToList();
        }

        public List<Project> GetAllProject()
        {
            Init();
            return conn.Table<Project>().ToList();
        }


     

        public void AddEmployee(Employee employee)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(employee);
        }

        public void AddAssignment(Assignment assignment)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(assignment);
        }

       
        public void AddDepartment(Department department)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(department);
        }

        public void AddProject(Project project)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(project);
        }


        public void DeleteEmployee(int emp_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Employee { Emp_id = emp_id });
        }
        public void DeleteAssignment(int assignment_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Assignment { Assignment_id = assignment_id });
        }
        public void DeleteDepartment(int dept_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Department { Dept_id = dept_id });
        }
        public void DeleteProject(int project_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Project { Project_id = project_id  });
        }

   
    }
}
