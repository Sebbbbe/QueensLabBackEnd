using EvaluationAssignmentQueensLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvaluationAssignmentQueensLab.Configuration
{
    public class VisitorConfiguration : IEntityTypeConfiguration<Visitor>

    {
        public void Configure(EntityTypeBuilder<Visitor> modelBuilder)
        {
            modelBuilder

          .Property(visitor => visitor.VisitorID)
               .ValueGeneratedOnAdd();


            modelBuilder
                .HasOne(visitor => visitor.Shop)
                .WithMany(shop => shop.Visitors)
                .HasForeignKey(visitor => visitor.ShopID);



            modelBuilder
               .HasOne(visitor => visitor.Section)
               .WithMany(section => section.Visitors)
               .HasForeignKey(visitor => visitor.SectionID);







        }
    }
}
