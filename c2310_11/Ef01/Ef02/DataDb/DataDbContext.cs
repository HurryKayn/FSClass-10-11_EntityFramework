using Ef02.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef02.DataDb
{
    internal class DataDbContext:DbContext
    {
        public DbSet<Alunno> Alunni {  get; set; } 

        private string connectionString = "Server=localhost;Database=CorsiAutunnali;Trusted_Connection=true";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
