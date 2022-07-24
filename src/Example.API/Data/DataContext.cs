using Example.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<City> Cities { get; set; }

        public DbSet<People> Peoples { get; set; }



    }
}
