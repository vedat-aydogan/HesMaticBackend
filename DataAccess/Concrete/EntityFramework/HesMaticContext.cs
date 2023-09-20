using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class HesMaticContext : DbContext
    {
        public HesMaticContext(DbContextOptions<HesMaticContext> options):base(options){}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     //@"Server=(localdb)\MSSQLLocalDB;Database=HesMaticStage;Trusted_Connection=true"
        //     optionsBuilder.UseSqlServer(_configuration.ConnectionString);
        //     base.OnConfiguring(optionsBuilder);
        // }

        //public DbSet<HesCode> HesCodes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<HesCode> HesCodes { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
