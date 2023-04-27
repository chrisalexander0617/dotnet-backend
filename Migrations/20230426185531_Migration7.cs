using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailwayAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleUIDHash",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleUIDHash",
                table: "Users",
                type: "text",
                nullable: true);
        }
    }
}
