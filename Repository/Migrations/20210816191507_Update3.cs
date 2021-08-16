using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Objectives",
                newName: "ObjectiveModes");

            migrationBuilder.RenameTable(
                name: "Encounters",
                newName: "EncounterToggles");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "CharacterRandoms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectiveModes",
                table: "ObjectiveModes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EncounterToggles",
                table: "EncounterToggles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterRandoms",
                table: "CharacterRandoms",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Prefixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefixes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prefixes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectiveModes",
                table: "ObjectiveModes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EncounterToggles",
                table: "EncounterToggles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterRandoms",
                table: "CharacterRandoms");

            migrationBuilder.RenameTable(
                name: "ObjectiveModes",
                newName: "Objectives");

            migrationBuilder.RenameTable(
                name: "EncounterToggles",
                newName: "Encounters");

            migrationBuilder.RenameTable(
                name: "CharacterRandoms",
                newName: "Characters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");
        }
    }
}
