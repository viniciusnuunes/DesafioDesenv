using DesafioDesenv.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DesafioDesenv.Repository
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ClienteDatabase")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add<PluralizingTableNameConvention>();
        }
    }
}