using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestao_Administrativa.Repository.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressModelId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Contact_ContactModelId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AddressModelId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ContactModelId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "AddressModelId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ContactModelId",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Customer",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ContactModelCustomerModel",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "integer", nullable: false),
                    CustomersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModelCustomerModel", x => new { x.ContactsId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_ContactModelCustomerModel_Contact_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactModelCustomerModel_Customer_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressId",
                table: "Customer",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactModelCustomerModel_CustomersId",
                table: "ContactModelCustomerModel",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_AddressId",
                table: "Customer",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "ContactModelCustomerModel");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AddressId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "AddressModelId",
                table: "Customer",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactModelId",
                table: "Customer",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressModelId",
                table: "Customer",
                column: "AddressModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ContactModelId",
                table: "Customer",
                column: "ContactModelId");

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
        }
    }
}
