using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundrySimulator2.Migrations
{
    /// <inheritdoc />
    public partial class DefaultInvListCleanUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 1,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Run of the mill variety detergent;", " - Laundry Detergent" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 2,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Your wallet. Tearing at the seams. Only a couple quarters;", " - Wallet" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 3,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Something from your youth. How did they get here?;", " - JNCO Jeans" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 4,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Black t-shirt with Sailor Saturn on it since she's your favorite;", " - Sailor Moon T-shirt" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 5,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Basic purple polo shirt you got as a gift;", " - Polo shirt with your name on it." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 1,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Run of the mill variety detergent.", "Laundry Detergent" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 2,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Your wallet. Tearing at the seams. Only a couple quarters.", "Wallet" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 3,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Something from your youth. How did they get here?", "JNCO Jeans" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 4,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Black t-shirt with Sailor Saturn on it since she's your favorite.", "Sailor Moon T-shirt" });

            migrationBuilder.UpdateData(
                table: "DefaultInventory",
                keyColumn: "InvId",
                keyValue: 5,
                columns: new[] { "ItemDescription", "ItemName" },
                values: new object[] { "Basic purple polo shirt you got as a gift.", "Polo shirt with your name on it." });
        }
    }
}
