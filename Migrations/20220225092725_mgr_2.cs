using Microsoft.EntityFrameworkCore.Migrations;

namespace Diarymous.Migrations
{
    public partial class mgr_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries");

            migrationBuilder.RenameTable(
                name: "Diaries",
                newName: "diaries");

            migrationBuilder.AddColumn<int>(
                name: "authorid",
                table: "diaries",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_diaries",
                table: "diaries",
                column: "id");

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diaries_authorid",
                table: "diaries",
                column: "authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_diaries_accounts_authorid",
                table: "diaries",
                column: "authorid",
                principalTable: "accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diaries_accounts_authorid",
                table: "diaries");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_diaries",
                table: "diaries");

            migrationBuilder.DropIndex(
                name: "IX_diaries_authorid",
                table: "diaries");

            migrationBuilder.DropColumn(
                name: "authorid",
                table: "diaries");

            migrationBuilder.RenameTable(
                name: "diaries",
                newName: "Diaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries",
                column: "id");
        }
    }
}
