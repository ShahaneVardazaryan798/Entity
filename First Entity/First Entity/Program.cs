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
            return $"Data Source={SQLEXPRESS};Initial Catalog={University};Integrated Security=True";
        }
        
    }
     class StudentDbcontext:DbContext
    {
       public StudentDbcontext():base($"Data Source=SQLEXPRESS;Initial Catalog=University;Integrated Security=True")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student()
            {
                Name = "Shahane",
                Category="developer"

            };
            var stcontext = new StudentDbcontext();
            stcontext.Students.Add(st);
            stcontext.SaveChanges();
        }
    }
}
