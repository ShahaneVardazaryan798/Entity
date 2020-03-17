using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
