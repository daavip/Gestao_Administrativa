using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class SubscriptionModelMapping : IEntityTypeConfiguration<SubscriptionModel>
    {
        public void Configure(EntityTypeBuilder<SubscriptionModel> builder)
        {
            builder.ToTable("subscription");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdSubscriptionType)
                .HasColumnName("id_subscription_type")
                .UseIdentityColumn();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("price");

            builder.Property(x => x.Up)
                .HasMaxLength(100)
                .HasColumnName("up");

            builder.Property(x => x.Down)
                .HasMaxLength(100)
                .HasColumnName("down");

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at");

            builder.HasOne(x => x.SubscriptionType)
               .WithMany(x => x.Subscriptions)
               .HasForeignKey(x => x.IdSubscriptionType);
        }
    }
}
