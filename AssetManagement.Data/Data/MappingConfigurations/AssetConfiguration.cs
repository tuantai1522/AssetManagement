using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations
{
    internal class AssetConfiguration
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            #region define index

            builder
                .HasOne(asset => asset.Category)
                .WithMany(cat => cat.Assets)
                .HasForeignKey(asset => asset.CategoryId)
                .IsRequired();

            #endregion

            builder
                .Property(e => e.State)
                .HasConversion<string>();

        }
    }
}
