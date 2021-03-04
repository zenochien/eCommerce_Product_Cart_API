using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRoles>
    {
        public void Configure(EntityTypeBuilder<AppRoles> builder)
        {
            builder.ToTable("AppRoles");
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}
