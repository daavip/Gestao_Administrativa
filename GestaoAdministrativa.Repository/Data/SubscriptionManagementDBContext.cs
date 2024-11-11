using Gestão_Administrativa.Data.Map;
using Gestão_Administrativa.Domain.Models;
using Gestao_Administrativa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Gestão_Administrativa.Repository.Data
{
    public class SubscriptionManagementDBContext : DbContext
    {
        public SubscriptionManagementDBContext(DbContextOptions<SubscriptionManagementDBContext> options) : base(options) { }

        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<SubscriptionModel> Subscriptions { get; set; }
        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<ContractModel> Contract { get; set; }
        public DbSet<SubscriptionContractModel> SubscriptionContract { get; set; }
        public DbSet<SubscriptionTypeModel> SubscriptionType { get; set; }
        public DbSet<CustomerContractModel> CustomerContract { get; set; }
        public DbSet<CustomerAddressModel> CustomerAddress { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configuração de relacionamento muitos-para-muitos entre Customer e Address
            modelBuilder.Entity<CustomerAddressModel>()
                .HasOne(ca => ca.Customer)
                .WithMany()
                .HasForeignKey(ca => ca.CustomerId);

            modelBuilder.Entity<CustomerAddressModel>()
                .HasOne(ca => ca.Address)
                .WithMany()
                .HasForeignKey(ca => ca.AddressId);

            // Configuração de relacionamento muitos-para-muitos entre Customer e Contract
            modelBuilder.Entity<CustomerContractModel>()
                .HasOne(cc => cc.Customer)
                .WithMany()
                .HasForeignKey(cc => cc.CustomerId);

            modelBuilder.Entity<CustomerContractModel>()
                .HasOne(cc => cc.Contract)
                .WithMany()
                .HasForeignKey(cc => cc.ContractId);

            // Configuração de relacionamento muitos-para-muitos entre Subscription e Contract
            modelBuilder.Entity<SubscriptionContractModel>()
                .HasOne(sc => sc.Subscription)
                .WithMany(s => s.SubscriptionContracts)
                .HasForeignKey(sc => sc.SubscriptionId);

            modelBuilder.Entity<SubscriptionContractModel>()
                .HasOne(sc => sc.Contract)
                .WithMany()
                .HasForeignKey(sc => sc.ContractId);

            // Configuração de relacionamento um-para-muitos entre SubscriptionType e Subscription
            modelBuilder.Entity<SubscriptionModel>()
                .HasOne<SubscriptionTypeModel>()
                .WithMany(st => st.Subscriptions)
                .HasForeignKey(s => s.Id);
        }
    }
}
