using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder
                .HasOne(assignment => assignment.AssignedToUser)
                .WithMany(user => user.AssignedToAssignments)
                .HasForeignKey(assignment => assignment.AssignedToId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(assignment => assignment.AssignedByUser)
                .WithMany(user => user.AssignedByAssignments)
                .HasForeignKey(assignment => assignment.AssignedById)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder
                .HasOne(assignment => assignment.Asset)
                .WithMany(asset => asset.Assignments)
                .HasForeignKey(assignment => assignment.AssetId)
                .IsRequired();
        }
    }
}