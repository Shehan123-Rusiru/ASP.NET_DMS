using Microsoft.EntityFrameworkCore;
using Sheffield_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.Data
{
   
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options){ }
    
        public DbSet<Student> students { get; set; }

   
    }
}
