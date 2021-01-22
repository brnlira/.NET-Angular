using Microsoft.EntityFrameworkCore;
using PBT.API.Model;

namespace PBT.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CSessao> CSessao { get; set; }
    }
}