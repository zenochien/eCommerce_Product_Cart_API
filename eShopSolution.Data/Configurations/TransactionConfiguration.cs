using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transations>
    {


        public void Configure(EntityTypeBuilder<Transations> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions)
                .HasForeignKey(x => x.UserId);
        }
    }
}
