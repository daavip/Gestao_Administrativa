using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class CustomerModelMapping : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> builder)
        {

            builder.ToTable("customer");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdAddress)
                .HasColumnName("id_address")
                .UseIdentityColumn();

            builder.Property(x => x.IdContact)
                .HasColumnName("id_contact")
                .UseIdentityColumn();

            builder.Property(x => x.IdContract)
                .HasColumnName("id_contract")
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Name)
                .HasColumnName("cpf_cnpj")
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(x => x.Addresses)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.IdAddress);

            builder.HasMany(x => x.Contacts)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.IdContact);

            builder.HasMany(x => x.Contracts)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.IdContract);
        }
    }
}
