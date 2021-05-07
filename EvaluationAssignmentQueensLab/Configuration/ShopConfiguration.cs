using EvaluationAssignmentQueensLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvaluationAssignmentQueensLab.Configuration
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> modelBuilder)
        {
            modelBuilder

                   .Property(shop => shop.ShopID)
               .ValueGeneratedOnAdd();



            modelBuilder

                .HasMany(shop => shop.Sections)
                .WithOne(section => section.Shop);



            modelBuilder

                .HasMany(shop => shop.Visitors)
                .WithOne(visitor => visitor.Shop);



        }

    }
}
