using Microsoft.EntityFrameworkCore;
using Salão.Models;

namespace Salão
{
    public class Contexto : DbContext
    {
        

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<administracao> administracao { get; set; }
        public DbSet<cadastro_cliente> cadastro_cliente { get; set; }
        public DbSet<cliente> cliente { get; set; }
        public DbSet<estoque> estoque { get; set; }
    }
}
