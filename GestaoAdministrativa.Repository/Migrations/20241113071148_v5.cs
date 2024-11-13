using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gestão_Administrativa.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Address_AddressId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Customer_CustomerId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressModelId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Contact_ContactModelId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Customer_CustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContract_Contract_ContractId",
                table: "CustomerContract");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContract_Customer_CustomerId",
                table: "CustomerContract");

            migrationBuilder.DropTable(
                name: "SubscriptionContract");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AddressModelId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ContactModelId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.DropIndex(
                name: "IX_Contract_AddressId",
                table: "Contract");

            migrationBuilder.DropIndex(
                name: "IX_Contract_CustomerId",
                table: "Contract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubscriptionType",
                table: "SubscriptionType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerContract",
                table: "CustomerContract");

            migrationBuilder.DropIndex(
                name: "IX_CustomerContract_CustomerId",
                table: "CustomerContract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "customer");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "contract");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "contact");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "address");

            migrationBuilder.RenameTable(
                name: "SubscriptionType",
                newName: "subscription_type");

            migrationBuilder.RenameTable(
                name: "CustomerContract",
                newName: "customer_contract");

            migrationBuilder.RenameTable(
                name: "CustomerAddress",
                newName: "customer_address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "customer",
                newName: "cpf_cnpj");

            migrationBuilder.RenameColumn(
                name: "ContactModelId",
                table: "customer",
                newName: "id_contract");

            migrationBuilder.RenameColumn(
                name: "AddressModelId",
                table: "customer",
                newName: "id_contact");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "contract",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "contract",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "StatusCtId",
                table: "contract",
                newName: "id_subscription");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "contract",
                newName: "id_status");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "contract",
                newName: "id_customer");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "contract",
                newName: "due_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "contact",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ContactType",
                table: "contact",
                newName: "contact_type");

            migrationBuilder.RenameColumn(
                name: "ContactInfo",
                table: "contact",
                newName: "contact_info");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "address",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "address",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "address",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "subscription_type",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "subscription_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer_contract",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "customer_contract",
                newName: "id_customer");

            migrationBuilder.RenameColumn(
                name: "ContractId",
                table: "customer_contract",
                newName: "id_contract");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerContract_ContractId",
                table: "customer_contract",
                newName: "IX_customer_contract_id_contract");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer_address",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "customer_address",
                newName: "id_customer");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "customer_address",
                newName: "id_contact");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddress_AddressId",
                table: "customer_address",
                newName: "IX_customer_address_id_contact");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "customer",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf_cnpj",
                table: "customer",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_contract",
                table: "customer",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_contact",
                table: "customer",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id_address",
                table: "customer",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_subscription",
                table: "contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_status",
                table: "contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_customer",
                table: "contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdEquipment",
                table: "contract",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "discount",
                table: "contract",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "increase",
                table: "contract",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "contact_type",
                table: "contact",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contact_info",
                table: "contact",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_customer",
                table: "address",
                type: "integer",
                nullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "subscription_type",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_customer",
                table: "customer_contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_contract",
                table: "customer_contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_customer",
                table: "customer_address",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id_contact",
                table: "customer_address",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contract",
                table: "contract",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contact",
                table: "contact",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_address",
                table: "address",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subscription_type",
                table: "subscription_type",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer_contract",
                table: "customer_contract",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer_address",
                table: "customer_address",
                column: "id");

            migrationBuilder.CreateTable(
                name: "customer_contact",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_customer = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_contact = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_contact", x => x.id);
                    table.ForeignKey(
                        name: "FK_customer_contact_contact_id_contact",
                        column: x => x.id_contact,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customer_contact_customer_id_contact",
                        column: x => x.id_contact,
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "status_contract",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_contract", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscription",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_subscription_type = table.Column<int>(type: "integer", nullable: true)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    up = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    down = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscription", x => x.id);
                    table.ForeignKey(
                        name: "FK_subscription_subscription_type_id_subscription_type",
                        column: x => x.id_subscription_type,
                        principalTable: "subscription_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "subscription_contract",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_contract = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_subscription = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscription_contract", x => x.id);
                    table.ForeignKey(
                        name: "FK_subscription_contract_contract_id_contract",
                        column: x => x.id_contract,
                        principalTable: "contract",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subscription_contract_subscription_id_subscription",
                        column: x => x.id_subscription,
                        principalTable: "subscription",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contract_id_status",
                table: "contract",
                column: "id_status");

            migrationBuilder.CreateIndex(
                name: "IX_customer_contact_id_contact",
                table: "customer_contact",
                column: "id_contact");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_id_subscription_type",
                table: "subscription",
                column: "id_subscription_type");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_contract_id_contract",
                table: "subscription_contract",
                column: "id_contract");

            migrationBuilder.CreateIndex(
                name: "IX_subscription_contract_id_subscription",
                table: "subscription_contract",
                column: "id_subscription");

            migrationBuilder.AddForeignKey(
                name: "FK_contract_status_contract_id_status",
                table: "contract",
                column: "id_status",
                principalTable: "status_contract",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_address_address_id_contact",
                table: "customer_address",
                column: "id_contact",
                principalTable: "address",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_address_customer_id_contact",
                table: "customer_address",
                column: "id_contact",
                principalTable: "customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_contract_contract_id_contract",
                table: "customer_contract",
                column: "id_contract",
                principalTable: "contract",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_contract_customer_id_contract",
                table: "customer_contract",
                column: "id_contract",
                principalTable: "customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contract_status_contract_id_status",
                table: "contract");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_address_address_id_contact",
                table: "customer_address");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_address_customer_id_contact",
                table: "customer_address");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_contract_contract_id_contract",
                table: "customer_contract");

            migrationBuilder.DropForeignKey(
                name: "FK_customer_contract_customer_id_contract",
                table: "customer_contract");

            migrationBuilder.DropTable(
                name: "customer_contact");

            migrationBuilder.DropTable(
                name: "status_contract");

            migrationBuilder.DropTable(
                name: "subscription_contract");

            migrationBuilder.DropTable(
                name: "subscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contract",
                table: "contract");

            migrationBuilder.DropIndex(
                name: "IX_contract_id_status",
                table: "contract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contact",
                table: "contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_address",
                table: "address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subscription_type",
                table: "subscription_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer_contract",
                table: "customer_contract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customer_address",
                table: "customer_address");

            migrationBuilder.DropColumn(
                name: "id_address",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "IdEquipment",
                table: "contract");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "contract");

            migrationBuilder.DropColumn(
                name: "increase",
                table: "contract");

            migrationBuilder.DropColumn(
                name: "id_customer",
                table: "address");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "contract",
                newName: "Contract");

            migrationBuilder.RenameTable(
                name: "contact",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "address",
                newName: "Address");

            migrationBuilder.RenameTable(
                name: "subscription_type",
                newName: "SubscriptionType");

            migrationBuilder.RenameTable(
                name: "customer_contract",
                newName: "CustomerContract");

            migrationBuilder.RenameTable(
                name: "customer_address",
                newName: "CustomerAddress");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "cpf_cnpj",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id_contract",
                table: "Customer",
                newName: "ContactModelId");

            migrationBuilder.RenameColumn(
                name: "id_contact",
                table: "Customer",
                newName: "AddressModelId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contract",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Contract",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id_subscription",
                table: "Contract",
                newName: "StatusCtId");

            migrationBuilder.RenameColumn(
                name: "id_status",
                table: "Contract",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "id_customer",
                table: "Contract",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "due_date",
                table: "Contract",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contact",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "contact_type",
                table: "Contact",
                newName: "ContactType");

            migrationBuilder.RenameColumn(
                name: "contact_info",
                table: "Contact",
                newName: "ContactInfo");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Address",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Address",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Address",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "SubscriptionType",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SubscriptionType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CustomerContract",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_customer",
                table: "CustomerContract",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "id_contract",
                table: "CustomerContract",
                newName: "ContractId");

            migrationBuilder.RenameIndex(
                name: "IX_customer_contract_id_contract",
                table: "CustomerContract",
                newName: "IX_CustomerContract_ContractId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CustomerAddress",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_customer",
                table: "CustomerAddress",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "id_contact",
                table: "CustomerAddress",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_customer_address_id_contact",
                table: "CustomerAddress",
                newName: "IX_CustomerAddress_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ContactModelId",
                table: "Customer",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AddressModelId",
                table: "Customer",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StatusCtId",
                table: "Contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "Contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Contract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ContactType",
                table: "Contact",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ContactInfo",
                table: "Contact",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SubscriptionType",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerContract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "ContractId",
                table: "CustomerContract",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerAddress",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "CustomerAddress",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubscriptionType",
                table: "SubscriptionType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerContract",
                table: "CustomerContract",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Down = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Up = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_SubscriptionType_Id",
                        column: x => x.Id,
                        principalTable: "SubscriptionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionContract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContractId = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionContract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionContract_Contract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionContract_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressModelId",
                table: "Customer",
                column: "AddressModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ContactModelId",
                table: "Customer",
                column: "ContactModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_AddressId",
                table: "Contract",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_CustomerId",
                table: "Contract",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContract_CustomerId",
                table: "CustomerContract",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionContract_ContractId",
                table: "SubscriptionContract",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionContract_SubscriptionId",
                table: "SubscriptionContract",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Address_AddressId",
                table: "Contract",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Customer_CustomerId",
                table: "Contract",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_AddressModelId",
                table: "Customer",
                column: "AddressModelId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Contact_ContactModelId",
                table: "Customer",
                column: "ContactModelId",
                principalTable: "Contact",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Customer_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContract_Contract_ContractId",
                table: "CustomerContract",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContract_Customer_CustomerId",
                table: "CustomerContract",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
