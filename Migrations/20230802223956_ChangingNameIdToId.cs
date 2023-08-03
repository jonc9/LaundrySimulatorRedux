using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaundrySimulator2.Migrations
{
    /// <inheritdoc />
    public partial class ChangingNameIdToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "PlayerNames",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlayerNames",
                newName: "NameId");
        }
    }
}
