using Gestão_Administrativa.Data.Map;
using Gestão_Administrativa.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestão_Administrativa.Data
{
    public class SubscriptionManagementDBContext : DbContext
    {
        public SubscriptionManagementDBContext(DbContextOptions<SubscriptionManagementDBContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<SubscriptionModel> Subscriptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SubscriptionMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
