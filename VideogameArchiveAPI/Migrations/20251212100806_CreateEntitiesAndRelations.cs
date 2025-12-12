using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VideogameArchiveAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateEntitiesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "CompanySequence");

            migrationBuilder.CreateTable(
                name: "CustomFolders",
                columns: table => new
                {
                    FolderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FolderName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFolders", x => x.FolderId);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CompanySequence\"')"),
                    CompanyName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "GameModes",
                columns: table => new
                {
                    GameModeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GameModeName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameModes", x => x.GameModeId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GenreName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"CompanySequence\"')"),
                    CompanyName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Videogames",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GameName = table.Column<string>(type: "text", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MinPlayers = table.Column<int>(type: "integer", nullable: false),
                    MaxPlayers = table.Column<int>(type: "integer", nullable: false),
                    EarlyAccess = table.Column<bool>(type: "boolean", nullable: false),
                    DLCOfWhatGameGameId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videogames", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Videogames_Videogames_DLCOfWhatGameGameId",
                        column: x => x.DLCOfWhatGameGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId");
                });

            migrationBuilder.CreateTable(
                name: "GamingPlatforms",
                columns: table => new
                {
                    ConsoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsoleName = table.Column<string>(type: "text", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PublisherCompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamingPlatforms", x => x.ConsoleId);
                    table.ForeignKey(
                        name: "FK_GamingPlatforms_Publishers_PublisherCompanyId",
                        column: x => x.PublisherCompanyId,
                        principalTable: "Publishers",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVideogame",
                columns: table => new
                {
                    UsersUserId = table.Column<string>(type: "text", nullable: false),
                    VideogamesGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVideogame", x => new { x.UsersUserId, x.VideogamesGameId });
                    table.ForeignKey(
                        name: "FK_UserVideogame_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVideogame_Videogames_VideogamesGameId",
                        column: x => x.VideogamesGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesDevelopers",
                columns: table => new
                {
                    DevelopersCompanyId = table.Column<int>(type: "integer", nullable: false),
                    GameListGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesDevelopers", x => new { x.DevelopersCompanyId, x.GameListGameId });
                    table.ForeignKey(
                        name: "FK_VideogamesDevelopers_Developers_DevelopersCompanyId",
                        column: x => x.DevelopersCompanyId,
                        principalTable: "Developers",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesDevelopers_Videogames_GameListGameId",
                        column: x => x.GameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesGameModes",
                columns: table => new
                {
                    GameModesGameModeId = table.Column<int>(type: "integer", nullable: false),
                    VideogameListGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesGameModes", x => new { x.GameModesGameModeId, x.VideogameListGameId });
                    table.ForeignKey(
                        name: "FK_VideogamesGameModes_GameModes_GameModesGameModeId",
                        column: x => x.GameModesGameModeId,
                        principalTable: "GameModes",
                        principalColumn: "GameModeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesGameModes_Videogames_VideogameListGameId",
                        column: x => x.VideogameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesGenres",
                columns: table => new
                {
                    GenresGenreId = table.Column<int>(type: "integer", nullable: false),
                    VideogameListGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesGenres", x => new { x.GenresGenreId, x.VideogameListGameId });
                    table.ForeignKey(
                        name: "FK_VideogamesGenres_Genres_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesGenres_Videogames_VideogameListGameId",
                        column: x => x.VideogameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesPublishers",
                columns: table => new
                {
                    GameListGameId = table.Column<int>(type: "integer", nullable: false),
                    PublishersCompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesPublishers", x => new { x.GameListGameId, x.PublishersCompanyId });
                    table.ForeignKey(
                        name: "FK_VideogamesPublishers_Publishers_PublishersCompanyId",
                        column: x => x.PublishersCompanyId,
                        principalTable: "Publishers",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesPublishers_Videogames_GameListGameId",
                        column: x => x.GameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesTags",
                columns: table => new
                {
                    TagsTagId = table.Column<int>(type: "integer", nullable: false),
                    VideogameListGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesTags", x => new { x.TagsTagId, x.VideogameListGameId });
                    table.ForeignKey(
                        name: "FK_VideogamesTags_Tag_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tag",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesTags_Videogames_VideogameListGameId",
                        column: x => x.VideogameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogameUsers",
                columns: table => new
                {
                    VideogameUserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideogameId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FromVideogameCollectionId = table.Column<int>(type: "integer", nullable: false),
                    HoursPlayed = table.Column<TimeSpan>(type: "interval", nullable: true),
                    GameStatus = table.Column<int>(type: "integer", nullable: false),
                    GameOwnership = table.Column<int>(type: "integer", nullable: false),
                    GamePriority = table.Column<int>(type: "integer", nullable: false),
                    GameFormat = table.Column<int>(type: "integer", nullable: false),
                    GameRegion = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionService = table.Column<int>(type: "integer", nullable: false),
                    BetaTested = table.Column<bool>(type: "boolean", nullable: false),
                    Infinite = table.Column<bool>(type: "boolean", nullable: false),
                    TimesCompleted = table.Column<int>(type: "integer", nullable: false),
                    AchievementsObtained = table.Column<int>(type: "integer", nullable: false),
                    AchievementsTotal = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogameUsers", x => x.VideogameUserId);
                    table.ForeignKey(
                        name: "FK_VideogameUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogameUsers_Videogames_FromVideogameCollectionId",
                        column: x => x.FromVideogameCollectionId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideogameUsers_Videogames_VideogameId",
                        column: x => x.VideogameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogamesConsoles",
                columns: table => new
                {
                    GamingPlatformsConsoleId = table.Column<int>(type: "integer", nullable: false),
                    VideogameListGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogamesConsoles", x => new { x.GamingPlatformsConsoleId, x.VideogameListGameId });
                    table.ForeignKey(
                        name: "FK_VideogamesConsoles_GamingPlatforms_GamingPlatformsConsoleId",
                        column: x => x.GamingPlatformsConsoleId,
                        principalTable: "GamingPlatforms",
                        principalColumn: "ConsoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogamesConsoles_Videogames_VideogameListGameId",
                        column: x => x.VideogameListGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomFolderVideogameUser",
                columns: table => new
                {
                    CustomFoldersFolderId = table.Column<int>(type: "integer", nullable: false),
                    VideogamesUserVideogameUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFolderVideogameUser", x => new { x.CustomFoldersFolderId, x.VideogamesUserVideogameUserId });
                    table.ForeignKey(
                        name: "FK_CustomFolderVideogameUser_CustomFolders_CustomFoldersFolder~",
                        column: x => x.CustomFoldersFolderId,
                        principalTable: "CustomFolders",
                        principalColumn: "FolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomFolderVideogameUser_VideogameUsers_VideogamesUserVide~",
                        column: x => x.VideogamesUserVideogameUserId,
                        principalTable: "VideogameUsers",
                        principalColumn: "VideogameUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vote = table.Column<double>(type: "double precision", nullable: false),
                    ReviewTitle = table.Column<string>(type: "text", nullable: false),
                    ReviewContent = table.Column<string>(type: "text", nullable: false),
                    VideogameUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_VideogameUsers_VideogameUserId",
                        column: x => x.VideogameUserId,
                        principalTable: "VideogameUsers",
                        principalColumn: "VideogameUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomFolderVideogameUser_VideogamesUserVideogameUserId",
                table: "CustomFolderVideogameUser",
                column: "VideogamesUserVideogameUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GamingPlatforms_PublisherCompanyId",
                table: "GamingPlatforms",
                column: "PublisherCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_VideogameUserId",
                table: "Review",
                column: "VideogameUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserVideogame_VideogamesGameId",
                table: "UserVideogame",
                column: "VideogamesGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_DLCOfWhatGameGameId",
                table: "Videogames",
                column: "DLCOfWhatGameGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesConsoles_VideogameListGameId",
                table: "VideogamesConsoles",
                column: "VideogameListGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesDevelopers_GameListGameId",
                table: "VideogamesDevelopers",
                column: "GameListGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesGameModes_VideogameListGameId",
                table: "VideogamesGameModes",
                column: "VideogameListGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesGenres_VideogameListGameId",
                table: "VideogamesGenres",
                column: "VideogameListGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesPublishers_PublishersCompanyId",
                table: "VideogamesPublishers",
                column: "PublishersCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogamesTags_VideogameListGameId",
                table: "VideogamesTags",
                column: "VideogameListGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_FromVideogameCollectionId",
                table: "VideogameUsers",
                column: "FromVideogameCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_UserId_VideogameId",
                table: "VideogameUsers",
                columns: new[] { "UserId", "VideogameId" });

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_VideogameId",
                table: "VideogameUsers",
                column: "VideogameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomFolderVideogameUser");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "UserVideogame");

            migrationBuilder.DropTable(
                name: "VideogamesConsoles");

            migrationBuilder.DropTable(
                name: "VideogamesDevelopers");

            migrationBuilder.DropTable(
                name: "VideogamesGameModes");

            migrationBuilder.DropTable(
                name: "VideogamesGenres");

            migrationBuilder.DropTable(
                name: "VideogamesPublishers");

            migrationBuilder.DropTable(
                name: "VideogamesTags");

            migrationBuilder.DropTable(
                name: "CustomFolders");

            migrationBuilder.DropTable(
                name: "VideogameUsers");

            migrationBuilder.DropTable(
                name: "GamingPlatforms");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "GameModes");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Videogames");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropSequence(
                name: "CompanySequence");
        }
    }
}
