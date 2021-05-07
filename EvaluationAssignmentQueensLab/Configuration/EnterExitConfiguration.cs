using EvaluationAssignmentQueensLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvaluationAssignmentQueensLab.Configuration
{
    public class EnterExitConfiguration : IEntityTypeConfiguration<EnterExit>
    {
        public void Configure(EntityTypeBuilder<EnterExit> modelBuilder)
        {
            modelBuilder
                .Property(enterExit => enterExit.EnterExitID)
                .ValueGeneratedOnAdd();

            modelBuilder
                 .HasMany(enterExit => enterExit.Visitors)
                 .WithOne(visitor => visitor.EnterExit);

        }


    }
}
