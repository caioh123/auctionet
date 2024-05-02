using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class typo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Male",
                table: "Items",
                newName: "Make");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Make",
                table: "Items",
                newName: "Male");
        }
    }
}
