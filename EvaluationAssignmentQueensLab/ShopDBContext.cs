using EvaluationAssignmentQueensLab.Configuration;
using EvaluationAssignmentQueensLab.Models;
using Microsoft.EntityFrameworkCore;


namespace EvaluationAssignmentQueensLab
{
    public class ShopDBContext : DbContext
    {

        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            new ShopConfiguration().Configure(modelBuilder.Entity<Shop>());
            new SectionConfiguration().Configure(modelBuilder.Entity<Section>());
            new VisitorConfiguration().Configure(modelBuilder.Entity<Visitor>());

            base.OnModelCreating(modelBuilder);





        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Section> sections { get; set; }
        public DbSet<Visitor> visitors { get; set; }

    }

}