using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class SubscriptionTypeModelMapping : IEntityTypeConfiguration<SubscriptionTypeModel>
    {
        public void Configure(EntityTypeBuilder<SubscriptionTypeModel> builder)
        {
            builder.ToTable("subscription_type");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
