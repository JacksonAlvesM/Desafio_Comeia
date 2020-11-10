using Desafio.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Desafio.DAO
{
    public class EmpresasContext : DbContext
    {

        public EmpresasContext() : base("EmpresasContext")
        {
        }

        public DbSet<Empresas> Empresas { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}