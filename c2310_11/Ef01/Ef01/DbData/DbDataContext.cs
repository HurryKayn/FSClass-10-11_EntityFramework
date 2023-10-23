using Ef01.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef01.DbData
{
    public class DbDataContext:DbContext
    {
        private string connectionString = "Server=localhost;Database=Registro;Trusted_Connection=true";
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Prodotto> Prodotti{ get; set; }

        public DbDataContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
