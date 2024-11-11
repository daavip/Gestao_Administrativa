using Gestão_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestão_Administrativa.Data.Map
{
    public class SubscriptionMap : IEntityTypeConfiguration<SubscriptionModel>
    {
        public void Configure(EntityTypeBuilder<SubscriptionModel> builder)
        {
            builder.HasKey(x=> x.Id);

        }
    }
}
