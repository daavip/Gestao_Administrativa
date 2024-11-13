using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestao_Administrativa.Domain.Models;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class ContactModelMapping : IEntityTypeConfiguration<ContactModel>
    {
        public void Configure(EntityTypeBuilder<ContactModel> builder)
        {

            builder.ToTable("contact");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.ContactInfo)
                .HasColumnName("contact_info")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.ContactType)
                .HasColumnName("contact_type")
                .IsRequired()
                .HasMaxLength(20);

            builder.HasMany(x => x.Customers)
                .WithOne(x => x.Contact)
                .HasForeignKey(x => x.IdContact);
        }
    }
}
