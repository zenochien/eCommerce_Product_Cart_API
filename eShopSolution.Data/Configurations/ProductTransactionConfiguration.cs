using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductTransactionConfiguration : IEntityTypeConfiguration<ProductTranslations>
    {
        public void Configure(EntityTypeBuilder<ProductTranslations> builder)
        {
            builder.ToTable("ProductTranslations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SeoAlials).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Details).HasMaxLength(500);
            builder.HasOne(x => x.Product).WithMany(x => x.ProductTranslations).HasForeignKey(x => x.ProductId);
        }
    }
}
