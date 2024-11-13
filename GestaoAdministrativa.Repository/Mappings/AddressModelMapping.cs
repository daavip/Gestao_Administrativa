using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class AddressModelMapping : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("address");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.IdCustomer)
                .HasColumnName("id_customer")
                .UseIdentityColumn();

            builder.Property(x => x.Number)
                .HasColumnName("number");

            builder.Property(x => x.CEP)
                .HasColumnName("cep");

            builder.HasMany(x => x.Customers)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.IdCustomer);
        }
    }
}
