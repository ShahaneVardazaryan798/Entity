using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace First_Entity
{
   
    
     
    class Program
    {
        static void Main(string[] args)
        {
            var stcontext = new StudentContext();
            var st = new Student()
            {
                Name = "Shahane",
                Category="developer"

            };
           
            stcontext.Students.Add(st);
            var tchcontext = new TeacherContext();
            var tch = new Teacher()
            {
                Name = "Vahe",
                Category = "developer"
            };
            tchcontext.Teachers.Add(tch);
            tchcontext.SaveChanges();
        }
    }
}
