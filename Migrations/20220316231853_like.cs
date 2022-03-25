using Microsoft.EntityFrameworkCore.Migrations;

namespace Diarymous.Migrations
{
    public partial class like : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountDiary",
                columns: table => new
                {
                    likedPostsid = table.Column<int>(type: "int", nullable: false),
                    likedUsersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDiary", x => new { x.likedPostsid, x.likedUsersid });
                    table.ForeignKey(
                        name: "FK_AccountDiary_accounts_likedUsersid",
                        column: x => x.likedUsersid,
                        principalTable: "accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountDiary_diaries_likedPostsid",
                        column: x => x.likedPostsid,
                        principalTable: "diaries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountDiary_likedUsersid",
                table: "AccountDiary",
                column: "likedUsersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountDiary");
        }
    }
}
