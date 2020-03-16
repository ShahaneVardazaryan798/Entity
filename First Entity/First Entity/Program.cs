using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace First_Entity
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Category { get; set; }

        public string CreatConnectionString(string SQLEXPRESS, string University)
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
        }
        
    }
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CreatConnectionString(string SQLEXPRESS, string University)
        {
            return @"Data Source=localhost\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";
        }
    }
     class StudentDbcontext:DbContext
     { 
       public StudentDbcontext():base(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=University;Integrated Security=True")
       {

       }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
     }
    class Program
    {
        static void Main(string[] args)
        {
            var stcontext = new StudentDbcontext();
            var st = new Student()
            {
                Name = "Shahane",
                Category="developer"

            };
           
            stcontext.Students.Add(st);

            var tch = new Teacher()
            {
                Name = "Vahe",
                Category = "developer"
            };
            stcontext.Teachers.Add(tch);
            stcontext.SaveChanges();
        }
    }
}
