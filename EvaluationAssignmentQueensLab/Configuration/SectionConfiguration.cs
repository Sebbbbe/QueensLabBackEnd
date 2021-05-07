using EvaluationAssignmentQueensLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvaluationAssignmentQueensLab.Configuration
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> modelBuilder)
        {

            modelBuilder

               .Property(section => section.SectionID)
               .ValueGeneratedOnAdd();

            modelBuilder

           .HasOne(section => section.Shop)
           .WithMany(shop => shop.Sections)
           .HasForeignKey(section => section.ShopID);

            modelBuilder
           .HasMany(section => section.Visitors)
           .WithOne(visitor => visitor.Section);





        }
    }
}
