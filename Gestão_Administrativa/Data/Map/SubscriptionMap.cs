using Gestão_Administrativa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestão_Administrativa.Data.Map
{
    public class SubscriptionMap : IEntityTypeConfiguration<SubscriptionModel>
    {
        public void Configure(EntityTypeBuilder<SubscriptionModel> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x=> x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired();

        }
    }
}
