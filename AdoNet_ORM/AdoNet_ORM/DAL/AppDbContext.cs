using AdoNet_ORM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet_ORM.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QBQM5QA\SQLEXPRESS;Database=BB202CodeFirst;Trusted_Connection=True;");            
        }
        public DbSet<Student> Students { get; set; }

    }
}
