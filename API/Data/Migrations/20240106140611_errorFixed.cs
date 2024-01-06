using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class errorFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Addres2",
                table: "UserAddress",
                newName: "Address2");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_Addres2",
                table: "Orders",
                newName: "ShippingAddress_Address2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "UserAddress",
                newName: "Addres2");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress_Address2",
                table: "Orders",
                newName: "ShippingAddress_Addres2");
        }
    }
}
