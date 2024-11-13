using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class SubscriptionContractModelMapping : IEntityTypeConfiguration<SubscriptionContractModel>
    {
        public void Configure(EntityTypeBuilder<SubscriptionContractModel> builder)
        {

            builder.ToTable("subscription_contract");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdSubscription)
                .HasColumnName("id_subscription")
                .UseIdentityColumn();

            builder.Property(x => x.IdContract)
                .HasColumnName("id_contract")
                .UseIdentityColumn();

            builder.HasOne(x => x.Subscription)
                .WithMany(x => x.Contracts)
                .HasForeignKey(x => x.IdSubscription);

            builder.HasOne(x => x.Contract)
                 .WithMany(x => x.Subscriptions)
                 .HasForeignKey(x => x.IdContract);
        }
    }
}
