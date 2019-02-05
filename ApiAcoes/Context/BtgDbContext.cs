using ApiAcoes.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ApiAcoes.Context
{
    public partial class BtgDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BTGBase"].ConnectionString);
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Acao> Acao { get; set; }
        public DbSet<Ordem> Ordem { get; set; }
    }
}
