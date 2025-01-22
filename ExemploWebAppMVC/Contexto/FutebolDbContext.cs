using ExemploWebAppMVC.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ExemploWebAppMVC.Contexto
{
    public class FutebolDbContext :DbContext
    {
        public FutebolDbContext(DbContextOptions<FutebolDbContext> options) : base(options) { 

        }

        //Inserir as tabelas
        public DbSet<Times> Times { get; set; }
    }
}
