using Gestao_Administrativa.Repository.Mappings;
using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Gestao_Administrativa.Repository.Data
{
    public class SubscriptionManagementDBContext : DbContext
    {
        public SubscriptionManagementDBContext(DbContextOptions<SubscriptionManagementDBContext> options) : base(options) { }

        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<SubscriptionModel> Subscription { get; set; }
        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<ContractModel> Contract { get; set; }
        public DbSet<SubscriptionContractModel> SubscriptionContract { get; set; }
        public DbSet<SubscriptionTypeModel> SubscriptionType { get; set; }
        public DbSet<CustomerContractModel> CustomerContract { get; set; }
        public DbSet<CustomerAddressModel> CustomerAddress { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AddressModelMapping());
            modelBuilder.ApplyConfiguration(new ContactModelMapping());
            modelBuilder.ApplyConfiguration(new ContractModelMapping());
            modelBuilder.ApplyConfiguration(new CustomerAddressModelMapping());
            modelBuilder.ApplyConfiguration(new CustomerContactModelMapping());
            modelBuilder.ApplyConfiguration(new CustomerContractModelMapping());
            modelBuilder.ApplyConfiguration(new CustomerModelMapping());
            modelBuilder.ApplyConfiguration(new StatusContractModelMapping());
            modelBuilder.ApplyConfiguration(new SubscriptionContractModelMapping());
            modelBuilder.ApplyConfiguration(new SubscriptionModelMapping());
            modelBuilder.ApplyConfiguration(new SubscriptionTypeModelMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
