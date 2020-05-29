using Microsoft.EntityFrameworkCore.Migrations;

namespace VanbaApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    MeaningAsNoun = table.Column<string>(nullable: true),
                    MeaningAsVerb = table.Column<string>(nullable: true),
                    MeaningAsAdjective = table.Column<string>(nullable: true),
                    Etymology = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Word");
        }
    }
}
