﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace First_Entity
{
    class TeacherContext:DbContext
    {
        public TeacherContext() : base(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=University;Integrated Security=True")
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
