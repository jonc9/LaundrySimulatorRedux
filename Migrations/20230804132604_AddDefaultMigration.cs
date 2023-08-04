using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaundrySimulator2.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultInventory",
                columns: table => new
                {
                    InvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_InvId", x => x.InvId);
                });

            migrationBuilder.InsertData(
                table: "DefaultInventory",
                columns: new[] { "InvId", "ItemDescription", "ItemName" },
                values: new object[,]
                {
                    { 1, "Run of the mill variety detergent.", "Laundry Detergent" },
                    { 2, "Your wallet. Tearing at the seams. Only a couple quarters.", "Wallet" },
                    { 3, "Something from your youth. How did they get here?", "JNCO Jeans" },
                    { 4, "Black t-shirt with Sailor Saturn on it since she's your favorite.", "Sailor Moon T-shirt" },
                    { 5, "Run of the mill variety detergent.", "Polo shirt with your name on it." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultInventory");
        }
    }
}
