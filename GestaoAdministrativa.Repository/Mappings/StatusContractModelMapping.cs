using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao_Administrativa.Repository.Mappings
{
    public class StatusContractModelMapping : IEntityTypeConfiguration<StatusContractModel>
    {
        public void Configure(EntityTypeBuilder<StatusContractModel> builder)
        {
            builder.ToTable("status_contract");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
