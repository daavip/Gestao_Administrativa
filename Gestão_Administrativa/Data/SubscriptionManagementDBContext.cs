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
        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<ContractModel> Contract { get; set; }
        public DbSet<StatusContactModel> StatusContact { get; set; }
        public DbSet<SubscriptionContractModel> SubscriptionContract { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new SubscriptionMap());
            base.OnModelCreating(modelBuilder);

            // Relacionamento Cliente -> Contato (1:1)
            modelBuilder.Entity<UserModel>()
                .HasOne(c => c.Contact)
                .WithMany()
                .HasForeignKey(c => c.IdContact)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento Cliente -> Endereco (1:1)
            modelBuilder.Entity<UserModel>()
                .HasOne(c => c.Address)
                .WithMany()
                .HasForeignKey(c => c.IdAddress)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento Contrato -> Cliente (N:1)
            modelBuilder.Entity<ContractModel>()
                .HasOne(ct => ct.User)
                .WithMany()
                .HasForeignKey(ct => ct.IdUser)
                .OnDelete(DeleteBehavior.Restrict);


            // Relacionamento Contrato -> Endereco (N:1)
            modelBuilder.Entity<ContractModel>()
                .HasOne(ct => ct.Address)
                .WithMany()
                .HasForeignKey(ct => ct.IdAddress)
                .OnDelete(DeleteBehavior.Restrict);
            
            // Relacionamento Contrato -> StatusCt (N:1)
            modelBuilder.Entity<ContractModel>()
                .HasOne(ct => ct.StatusContact)
                .WithMany()
                .HasForeignKey(ct => ct.StatusCtId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento ContratoPlano -> Contrato (N:1)
            modelBuilder.Entity<SubscriptionContractModel>()
                .HasOne(cp => cp.Contract)
                .WithMany()
                .HasForeignKey(cp => cp.IdContract)
                .OnDelete(DeleteBehavior.Restrict);


            // Relacionamento ContratoPlano -> Plano (N:1)
            modelBuilder.Entity<SubscriptionContractModel>()
                .HasOne(cp => cp.Subscription)
                .WithMany(p => p.SubscriptionContracts)
                .HasForeignKey(cp => cp.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
