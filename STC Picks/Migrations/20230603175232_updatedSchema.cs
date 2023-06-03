using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STC_Picks.Migrations
{
    /// <inheritdoc />
    public partial class updatedSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "score",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "score",
                table: "Users");
        }
    }
}
