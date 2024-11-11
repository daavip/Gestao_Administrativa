using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gestão_Administrativa.Domain.Models;

namespace Gestão_Administrativa.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
    
        }
    }
}
