using ExemploWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ExemploWebAPI.Context
{
    public class CarDBContext : DbContext
    {
        private readonly string _connectionString;

        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {
        }

        public CarDBContext(string connectionString) : base()
        {
            _connectionString = connectionString;

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(_connectionString);

        }


        public DbSet<CarModel> Cars { get; set; }
    }
}
