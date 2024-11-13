using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class CustomerAddressModelMapping : IEntityTypeConfiguration<CustomerAddressModel>
    {
        public void Configure(EntityTypeBuilder<CustomerAddressModel> builder)
        {
            builder.ToTable("customer_address");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdCustomer)
                .HasColumnName("id_customer")
                .UseIdentityColumn();

            builder.Property(x => x.IdAddress)
                .HasColumnName("id_contact")
                .UseIdentityColumn();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.IdCustomer);

            builder.HasOne(x => x.Address)
                 .WithMany(x => x.Customers)
                 .HasForeignKey(x => x.IdAddress);
        }
    }
}
