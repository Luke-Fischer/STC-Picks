using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STC_Picks.Migrations
{
    /// <inheritdoc />
    public partial class initDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    fullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accessCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    male8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    female8 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.fullName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
