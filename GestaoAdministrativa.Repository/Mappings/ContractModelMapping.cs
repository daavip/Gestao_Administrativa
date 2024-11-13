using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class ContractModelMapping : IEntityTypeConfiguration<ContractModel>
    {
        public void Configure(EntityTypeBuilder<ContractModel> builder)
        {

            builder.ToTable("contract");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdCustomer)
                .HasColumnName("id_customer")
                .UseIdentityColumn();

            builder.Property(x => x.IdSubscription)
                .HasColumnName("id_subscription")
                .UseIdentityColumn();

            builder.Property(x => x.IdStatus)
                .HasColumnName("id_status")
                .UseIdentityColumn();

            //builder.Property(x => x.IdEquipment)
            //    .HasColumnName("equipment")
            //    .UseIdentityColumn();

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(x => x.Discount)
                .HasColumnName("discount");

            builder.Property(x => x.Increase)
                .HasColumnName("increase");

            builder.Property(x => x.DueDate)
                .HasColumnName("due_date");

            builder.HasMany(x => x.Customers)
                .WithOne(x => x.Contract)
                .HasForeignKey(x => x.IdCustomer);

            builder.HasMany(x => x.Subscriptions)
                .WithOne(x => x.Contract)
                .HasForeignKey(x => x.IdSubscription);

            builder.HasOne(x => x.Status)
                .WithMany(x => x.Contracts)
                .HasForeignKey(x => x.IdStatus);

            //builder.HasMany(x => x.Equipments)
            //    .WithOne(x => x.Contract)
            //    .HasForeignKey(x => x.IdEquipment);
        }
    }
}
