using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundrySimulator2.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDescriptionPolo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 5,
                column: "ItemDescription",
                value: "Basic purple polo shirt you got as a gift.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 5,
                column: "ItemDescription",
                value: "Run of the mill variety detergent.");
        }
    }
}
