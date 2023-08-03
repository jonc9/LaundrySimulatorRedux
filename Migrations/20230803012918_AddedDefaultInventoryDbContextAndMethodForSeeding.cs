using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundrySimulator2.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultInventoryDbContextAndMethodForSeeding : Migration
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
                values: new object[] { 1, "Test description", "Mallet" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultInventory");
        }
    }
}
