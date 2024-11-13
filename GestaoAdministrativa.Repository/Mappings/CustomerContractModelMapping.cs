using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class CustomerContractModelMapping : IEntityTypeConfiguration<CustomerContractModel>
    {
        public void Configure(EntityTypeBuilder<CustomerContractModel> builder)
        {

            builder.ToTable("customer_contract");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdCustomer)
                .HasColumnName("id_customer")
                .UseIdentityColumn();

            builder.Property(x => x.IdContract)
                .HasColumnName("id_contract")
                .UseIdentityColumn();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Contracts)
                .HasForeignKey(x => x.IdCustomer);

            builder.HasOne(x => x.Contract)
                 .WithMany(x => x.Customers)
                 .HasForeignKey(x => x.IdContract);
        }
    }
}
