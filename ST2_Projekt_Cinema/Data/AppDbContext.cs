using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ST2_Projekt_Cinema.Models;

namespace ST2_Projekt_Cinema.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public AppDbContext (IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString(""));
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
