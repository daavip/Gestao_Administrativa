﻿// <auto-generated />
using System;
using Gestão_Administrativa.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gestão_Administrativa.Migrations
{
    [DbContext(typeof(SubscriptionManagementDBContext))]
    [Migration("20241111004334_AddNewTables")]
    partial class AddNewTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.CustomerAddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.CustomerContractModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerContract");
                });

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.SubscriptionTypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionType");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.AddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CEP")
                        .HasColumnType("integer");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.ContactModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactInfo")
                        .HasColumnType("text");

                    b.Property<string>("ContactType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.ContractModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusCtId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressModelId")
                        .HasColumnType("integer");

                    b.Property<int?>("ContactModelId")
                        .HasColumnType("integer");

                    b.Property<string>("CpfCnpj")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressModelId");

                    b.HasIndex("ContactModelId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.SubscriptionContractModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ContractId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionContract");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.SubscriptionModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Down")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("Up")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.CustomerAddressModel", b =>
                {
                    b.HasOne("Gestão_Administrativa.Domain.Models.AddressModel", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestão_Administrativa.Domain.Models.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.CustomerContractModel", b =>
                {
                    b.HasOne("Gestão_Administrativa.Domain.Models.ContractModel", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestão_Administrativa.Domain.Models.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.ContractModel", b =>
                {
                    b.HasOne("Gestão_Administrativa.Domain.Models.AddressModel", "Address")
                        .WithMany("Contracts")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestão_Administrativa.Domain.Models.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.CustomerModel", b =>
                {
                    b.HasOne("Gestão_Administrativa.Domain.Models.AddressModel", null)
                        .WithMany("Customers")
                        .HasForeignKey("AddressModelId");

                    b.HasOne("Gestão_Administrativa.Domain.Models.ContactModel", null)
                        .WithMany("Customers")
                        .HasForeignKey("ContactModelId");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.SubscriptionContractModel", b =>
                {
                    b.HasOne("Gestão_Administrativa.Domain.Models.ContractModel", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestão_Administrativa.Domain.Models.SubscriptionModel", "Subscription")
                        .WithMany("SubscriptionContracts")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.SubscriptionModel", b =>
                {
                    b.HasOne("Gestao_Administrativa.Domain.Models.SubscriptionTypeModel", null)
                        .WithMany("Subscriptions")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gestao_Administrativa.Domain.Models.SubscriptionTypeModel", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.AddressModel", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.ContactModel", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Gestão_Administrativa.Domain.Models.SubscriptionModel", b =>
                {
                    b.Navigation("SubscriptionContracts");
                });
#pragma warning restore 612, 618
        }
    }
}
