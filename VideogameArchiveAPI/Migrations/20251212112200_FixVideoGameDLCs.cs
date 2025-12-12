using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideogameArchiveAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixVideoGameDLCs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Videogames_DLCOfWhatGameGameId",
                table: "Videogames");

            migrationBuilder.RenameColumn(
                name: "DLCOfWhatGameGameId",
                table: "Videogames",
                newName: "DLCOfWhatGameId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_DLCOfWhatGameGameId",
                table: "Videogames",
                newName: "IX_Videogames_DLCOfWhatGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Videogames_DLCOfWhatGameId",
                table: "Videogames",
                column: "DLCOfWhatGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Videogames_DLCOfWhatGameId",
                table: "Videogames");

            migrationBuilder.RenameColumn(
                name: "DLCOfWhatGameId",
                table: "Videogames",
                newName: "DLCOfWhatGameGameId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_DLCOfWhatGameId",
                table: "Videogames",
                newName: "IX_Videogames_DLCOfWhatGameGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Videogames_DLCOfWhatGameGameId",
                table: "Videogames",
                column: "DLCOfWhatGameGameId",
                principalTable: "Videogames",
                principalColumn: "GameId");
        }
    }
}
