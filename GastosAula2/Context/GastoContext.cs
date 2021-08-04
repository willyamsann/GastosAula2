using GastosAula2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace GastosAula2.Context
{
    public class GastoContext : DbContext
    {
        public GastoContext(): base("Gastos")
        {
        }

        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
