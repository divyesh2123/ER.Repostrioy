using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class WeltecDatabase : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-BLNTEBH7\SQLEXPRESS;Database=EFCoreDemo1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }



    }
}
