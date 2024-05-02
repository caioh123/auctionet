using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixtypos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Items",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Winnter",
                table: "Auctions",
                newName: "Winner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Items",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Winner",
                table: "Auctions",
                newName: "Winnter");
        }
    }
}
