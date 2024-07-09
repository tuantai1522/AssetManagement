using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations {
    internal class RetuningRequestConfiguration {
        public void Configure(EntityTypeBuilder<ReturningRequest> builder) {
            builder.HasOne(r => r.Assignment)
                .WithOne()
                .HasForeignKey<ReturningRequest>(r => r.AssignmentId);
        }
    }
}
