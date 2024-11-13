using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class CustomerContactModelMapping : IEntityTypeConfiguration<CustomerContactModel>
    {
        public void Configure(EntityTypeBuilder<CustomerContactModel> builder)
        {

            builder.ToTable("customer_contact");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdCustomer)
                .HasColumnName("id_customer")
                .UseIdentityColumn();

            builder.Property(x => x.IdContact)
                .HasColumnName("id_contact")
                .UseIdentityColumn();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.IdCustomer);

            builder.HasOne(x => x.Contact)
                 .WithMany(x => x.Customers)
                 .HasForeignKey(x => x.IdContact);
        }
    }
}
