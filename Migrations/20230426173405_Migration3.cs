using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailwayAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoogleUID",
                table: "Users",
                newName: "GoogleUIDHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoogleUIDHash",
                table: "Users",
                newName: "GoogleUID");
        }
    }
}
