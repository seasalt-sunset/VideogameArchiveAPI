using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VideogameArchiveAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCompanyAndModifyCollectionsTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFolderVideogameUser_CustomFolders_CustomFoldersFolder~",
                table: "CustomFolderVideogameUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFolderVideogameUser_VideogameUsers_VideogamesUserVide~",
                table: "CustomFolderVideogameUser");

            migrationBuilder.DropForeignKey(
                name: "FK_GamingPlatforms_Publishers_PublisherCompanyId",
                table: "GamingPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesConsoles_GamingPlatforms_GamingPlatformsConsoleId",
                table: "VideogamesConsoles");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesConsoles_Videogames_VideogameListGameId",
                table: "VideogamesConsoles");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesDevelopers_Developers_DevelopersCompanyId",
                table: "VideogamesDevelopers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesDevelopers_Videogames_GameListGameId",
                table: "VideogamesDevelopers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesGameModes_GameModes_GameModesGameModeId",
                table: "VideogamesGameModes");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesGameModes_Videogames_VideogameListGameId",
                table: "VideogamesGameModes");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesGenres_Genres_GenresGenreId",
                table: "VideogamesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesGenres_Videogames_VideogameListGameId",
                table: "VideogamesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesPublishers_Publishers_PublishersCompanyId",
                table: "VideogamesPublishers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesPublishers_Videogames_GameListGameId",
                table: "VideogamesPublishers");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesTags_Tag_TagsTagId",
                table: "VideogamesTags");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogamesTags_Videogames_VideogameListGameId",
                table: "VideogamesTags");

            migrationBuilder.DropForeignKey(
                name: "FK_VideogameUsers_Videogames_FromVideogameCollectionId",
                table: "VideogameUsers");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "UserVideogame");

            migrationBuilder.DropIndex(
                name: "IX_VideogameUsers_FromVideogameCollectionId",
                table: "VideogameUsers");

            migrationBuilder.DropIndex(
                name: "IX_VideogameUsers_UserId_VideogameId",
                table: "VideogameUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamingPlatforms",
                table: "GamingPlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamingPlatforms_PublisherCompanyId",
                table: "GamingPlatforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesTags",
                table: "VideogamesTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesPublishers",
                table: "VideogamesPublishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesGenres",
                table: "VideogamesGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesGameModes",
                table: "VideogamesGameModes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesDevelopers",
                table: "VideogamesDevelopers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideogamesConsoles",
                table: "VideogamesConsoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomFolderVideogameUser",
                table: "CustomFolderVideogameUser");

            migrationBuilder.DropColumn(
                name: "AchievementsObtained",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "AchievementsTotal",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "FromVideogameCollectionId",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "GameFormat",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "GameOwnership",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "GamePriority",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "GameRegion",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "GameStatus",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "HoursPlayed",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "SubscriptionService",
                table: "VideogameUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "ConsoleId",
                table: "GamingPlatforms");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Developers");

            migrationBuilder.DropSequence(
                name: "CompanySequence");

            migrationBuilder.RenameTable(
                name: "VideogamesTags",
                newName: "Videogames_Tags");

            migrationBuilder.RenameTable(
                name: "VideogamesPublishers",
                newName: "Videogames_Publishers");

            migrationBuilder.RenameTable(
                name: "VideogamesGenres",
                newName: "Videogames_Genres");

            migrationBuilder.RenameTable(
                name: "VideogamesGameModes",
                newName: "Videogames_GameModes");

            migrationBuilder.RenameTable(
                name: "VideogamesDevelopers",
                newName: "Videogames_Developers");

            migrationBuilder.RenameTable(
                name: "VideogamesConsoles",
                newName: "Videogames_GamingPlatforms");

            migrationBuilder.RenameTable(
                name: "CustomFolderVideogameUser",
                newName: "CustomFolders_VideogameUsers");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "PublisherCompanyId",
                table: "GamingPlatforms",
                newName: "PlatformId");

            migrationBuilder.RenameColumn(
                name: "ConsoleName",
                table: "GamingPlatforms",
                newName: "PlatformName");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Developers",
                newName: "DeveloperName");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesTags_VideogameListGameId",
                table: "Videogames_Tags",
                newName: "IX_Videogames_Tags_VideogameListGameId");

            migrationBuilder.RenameColumn(
                name: "PublishersCompanyId",
                table: "Videogames_Publishers",
                newName: "PublishersPublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesPublishers_PublishersCompanyId",
                table: "Videogames_Publishers",
                newName: "IX_Videogames_Publishers_PublishersPublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesGenres_VideogameListGameId",
                table: "Videogames_Genres",
                newName: "IX_Videogames_Genres_VideogameListGameId");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesGameModes_VideogameListGameId",
                table: "Videogames_GameModes",
                newName: "IX_Videogames_GameModes_VideogameListGameId");

            migrationBuilder.RenameColumn(
                name: "DevelopersCompanyId",
                table: "Videogames_Developers",
                newName: "DevelopersDeveloperId");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesDevelopers_GameListGameId",
                table: "Videogames_Developers",
                newName: "IX_Videogames_Developers_GameListGameId");

            migrationBuilder.RenameColumn(
                name: "GamingPlatformsConsoleId",
                table: "Videogames_GamingPlatforms",
                newName: "GamingPlatformsPlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_VideogamesConsoles_VideogameListGameId",
                table: "Videogames_GamingPlatforms",
                newName: "IX_Videogames_GamingPlatforms_VideogameListGameId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomFolderVideogameUser_VideogamesUserVideogameUserId",
                table: "CustomFolders_VideogameUsers",
                newName: "IX_CustomFolders_VideogameUsers_VideogamesUserVideogameUserId");

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Videogames",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "FromVideogameCollectionId",
                table: "Videogames",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "PlatformId",
                table: "GamingPlatforms",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "GamingPlatforms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Developers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamingPlatforms",
                table: "GamingPlatforms",
                column: "PlatformId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "DeveloperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_Tags",
                table: "Videogames_Tags",
                columns: new[] { "TagsTagId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_Publishers",
                table: "Videogames_Publishers",
                columns: new[] { "GameListGameId", "PublishersPublisherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_Genres",
                table: "Videogames_Genres",
                columns: new[] { "GenresGenreId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_GameModes",
                table: "Videogames_GameModes",
                columns: new[] { "GameModesGameModeId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_Developers",
                table: "Videogames_Developers",
                columns: new[] { "DevelopersDeveloperId", "GameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videogames_GamingPlatforms",
                table: "Videogames_GamingPlatforms",
                columns: new[] { "GamingPlatformsPlatformId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomFolders_VideogameUsers",
                table: "CustomFolders_VideogameUsers",
                columns: new[] { "CustomFoldersFolderId", "VideogamesUserVideogameUserId" });

            migrationBuilder.CreateTable(
                name: "RealOwners",
                columns: table => new
                {
                    RealOwnerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RealOwnerName = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealOwners", x => x.RealOwnerId);
                    table.ForeignKey(
                        name: "FK_RealOwners_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vote = table.Column<double>(type: "double precision", nullable: true),
                    ReviewTitle = table.Column<string>(type: "text", nullable: false),
                    ReviewContent = table.Column<string>(type: "text", nullable: false),
                    VideogameUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_VideogameUsers_VideogameUserId",
                        column: x => x.VideogameUserId,
                        principalTable: "VideogameUsers",
                        principalColumn: "VideogameUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionServices",
                columns: table => new
                {
                    SubscriptionServiceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubscriptionServiceName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionServices", x => x.SubscriptionServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionServices_Videogames",
                columns: table => new
                {
                    SubscriptionServicesSubscriptionServiceId = table.Column<int>(type: "integer", nullable: false),
                    VideogamesGameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionServices_Videogames", x => new { x.SubscriptionServicesSubscriptionServiceId, x.VideogamesGameId });
                    table.ForeignKey(
                        name: "FK_SubscriptionServices_Videogames_SubscriptionServices_Subscr~",
                        column: x => x.SubscriptionServicesSubscriptionServiceId,
                        principalTable: "SubscriptionServices",
                        principalColumn: "SubscriptionServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionServices_Videogames_Videogames_VideogamesGameId",
                        column: x => x.VideogamesGameId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogameCopies",
                columns: table => new
                {
                    VideogameCopyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideogameUserId = table.Column<int>(type: "integer", nullable: false),
                    FromVideogameCollectionId = table.Column<int>(type: "integer", nullable: false),
                    HoursPlayed = table.Column<TimeSpan>(type: "interval", nullable: true),
                    GameStatus = table.Column<int>(type: "integer", nullable: false),
                    GameOwnership = table.Column<int>(type: "integer", nullable: false),
                    GamePriority = table.Column<int>(type: "integer", nullable: false),
                    GameFormat = table.Column<int>(type: "integer", nullable: false),
                    GameRegion = table.Column<int>(type: "integer", nullable: false),
                    SubscriptionServiceId = table.Column<int>(type: "integer", nullable: false),
                    AchievementsObtained = table.Column<int>(type: "integer", nullable: false),
                    AchievementsTotal = table.Column<int>(type: "integer", nullable: false),
                    PlayedFrom = table.Column<DateOnly>(type: "date", nullable: true),
                    PlayedTo = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogameCopies", x => x.VideogameCopyId);
                    table.ForeignKey(
                        name: "FK_VideogameCopies_SubscriptionServices_SubscriptionServiceId",
                        column: x => x.SubscriptionServiceId,
                        principalTable: "SubscriptionServices",
                        principalColumn: "SubscriptionServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogameCopies_VideogameUsers_VideogameUserId",
                        column: x => x.VideogameUserId,
                        principalTable: "VideogameUsers",
                        principalColumn: "VideogameUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogameCopies_Videogames_FromVideogameCollectionId",
                        column: x => x.FromVideogameCollectionId,
                        principalTable: "Videogames",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomFolders_VideogameCopies",
                columns: table => new
                {
                    CustomFoldersFolderId = table.Column<int>(type: "integer", nullable: false),
                    VideogameCopiesVideogameCopyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFolders_VideogameCopies", x => new { x.CustomFoldersFolderId, x.VideogameCopiesVideogameCopyId });
                    table.ForeignKey(
                        name: "FK_CustomFolders_VideogameCopies_CustomFolders_CustomFoldersFo~",
                        column: x => x.CustomFoldersFolderId,
                        principalTable: "CustomFolders",
                        principalColumn: "FolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomFolders_VideogameCopies_VideogameCopies_VideogameCopi~",
                        column: x => x.VideogameCopiesVideogameCopyId,
                        principalTable: "VideogameCopies",
                        principalColumn: "VideogameCopyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideogameCopy_RealOwner",
                columns: table => new
                {
                    RealOwnersRealOwnerId = table.Column<int>(type: "integer", nullable: false),
                    VideogameCopiesVideogameCopyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideogameCopy_RealOwner", x => new { x.RealOwnersRealOwnerId, x.VideogameCopiesVideogameCopyId });
                    table.ForeignKey(
                        name: "FK_VideogameCopy_RealOwner_RealOwners_RealOwnersRealOwnerId",
                        column: x => x.RealOwnersRealOwnerId,
                        principalTable: "RealOwners",
                        principalColumn: "RealOwnerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideogameCopy_RealOwner_VideogameCopies_VideogameCopiesVide~",
                        column: x => x.VideogameCopiesVideogameCopyId,
                        principalTable: "VideogameCopies",
                        principalColumn: "VideogameCopyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_UserId_VideogameId",
                table: "VideogameUsers",
                columns: new[] { "UserId", "VideogameId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_FromVideogameCollectionId",
                table: "Videogames",
                column: "FromVideogameCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_GameName",
                table: "Videogames",
                column: "GameName");

            migrationBuilder.CreateIndex(
                name: "IX_GamingPlatforms_PublisherId",
                table: "GamingPlatforms",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFolders_FolderName",
                table: "CustomFolders",
                column: "FolderName");

            migrationBuilder.CreateIndex(
                name: "IX_CustomFolders_VideogameCopies_VideogameCopiesVideogameCopyId",
                table: "CustomFolders_VideogameCopies",
                column: "VideogameCopiesVideogameCopyId");

            migrationBuilder.CreateIndex(
                name: "IX_RealOwners_UserId",
                table: "RealOwners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_VideogameUserId",
                table: "Reviews",
                column: "VideogameUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionServices_Videogames_VideogamesGameId",
                table: "SubscriptionServices_Videogames",
                column: "VideogamesGameId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameCopies_FromVideogameCollectionId",
                table: "VideogameCopies",
                column: "FromVideogameCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameCopies_SubscriptionServiceId",
                table: "VideogameCopies",
                column: "SubscriptionServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameCopies_VideogameUserId",
                table: "VideogameCopies",
                column: "VideogameUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameCopy_RealOwner_VideogameCopiesVideogameCopyId",
                table: "VideogameCopy_RealOwner",
                column: "VideogameCopiesVideogameCopyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFolders_VideogameUsers_CustomFolders_CustomFoldersFol~",
                table: "CustomFolders_VideogameUsers",
                column: "CustomFoldersFolderId",
                principalTable: "CustomFolders",
                principalColumn: "FolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFolders_VideogameUsers_VideogameUsers_VideogamesUserV~",
                table: "CustomFolders_VideogameUsers",
                column: "VideogamesUserVideogameUserId",
                principalTable: "VideogameUsers",
                principalColumn: "VideogameUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamingPlatforms_Publishers_PublisherId",
                table: "GamingPlatforms",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Videogames_FromVideogameCollectionId",
                table: "Videogames",
                column: "FromVideogameCollectionId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Developers_Developers_DevelopersDeveloperId",
                table: "Videogames_Developers",
                column: "DevelopersDeveloperId",
                principalTable: "Developers",
                principalColumn: "DeveloperId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Developers_Videogames_GameListGameId",
                table: "Videogames_Developers",
                column: "GameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_GameModes_GameModes_GameModesGameModeId",
                table: "Videogames_GameModes",
                column: "GameModesGameModeId",
                principalTable: "GameModes",
                principalColumn: "GameModeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_GameModes_Videogames_VideogameListGameId",
                table: "Videogames_GameModes",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_GamingPlatforms_GamingPlatforms_GamingPlatformsP~",
                table: "Videogames_GamingPlatforms",
                column: "GamingPlatformsPlatformId",
                principalTable: "GamingPlatforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_GamingPlatforms_Videogames_VideogameListGameId",
                table: "Videogames_GamingPlatforms",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Genres_Genres_GenresGenreId",
                table: "Videogames_Genres",
                column: "GenresGenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Genres_Videogames_VideogameListGameId",
                table: "Videogames_Genres",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Publishers_Publishers_PublishersPublisherId",
                table: "Videogames_Publishers",
                column: "PublishersPublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Publishers_Videogames_GameListGameId",
                table: "Videogames_Publishers",
                column: "GameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Tags_Tags_TagsTagId",
                table: "Videogames_Tags",
                column: "TagsTagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_Tags_Videogames_VideogameListGameId",
                table: "Videogames_Tags",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFolders_VideogameUsers_CustomFolders_CustomFoldersFol~",
                table: "CustomFolders_VideogameUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFolders_VideogameUsers_VideogameUsers_VideogamesUserV~",
                table: "CustomFolders_VideogameUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GamingPlatforms_Publishers_PublisherId",
                table: "GamingPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Videogames_FromVideogameCollectionId",
                table: "Videogames");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Developers_Developers_DevelopersDeveloperId",
                table: "Videogames_Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Developers_Videogames_GameListGameId",
                table: "Videogames_Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_GameModes_GameModes_GameModesGameModeId",
                table: "Videogames_GameModes");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_GameModes_Videogames_VideogameListGameId",
                table: "Videogames_GameModes");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_GamingPlatforms_GamingPlatforms_GamingPlatformsP~",
                table: "Videogames_GamingPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_GamingPlatforms_Videogames_VideogameListGameId",
                table: "Videogames_GamingPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Genres_Genres_GenresGenreId",
                table: "Videogames_Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Genres_Videogames_VideogameListGameId",
                table: "Videogames_Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Publishers_Publishers_PublishersPublisherId",
                table: "Videogames_Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Publishers_Videogames_GameListGameId",
                table: "Videogames_Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Tags_Tags_TagsTagId",
                table: "Videogames_Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_Tags_Videogames_VideogameListGameId",
                table: "Videogames_Tags");

            migrationBuilder.DropTable(
                name: "CustomFolders_VideogameCopies");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubscriptionServices_Videogames");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "VideogameCopy_RealOwner");

            migrationBuilder.DropTable(
                name: "RealOwners");

            migrationBuilder.DropTable(
                name: "VideogameCopies");

            migrationBuilder.DropTable(
                name: "SubscriptionServices");

            migrationBuilder.DropIndex(
                name: "IX_VideogameUsers_UserId_VideogameId",
                table: "VideogameUsers");

            migrationBuilder.DropIndex(
                name: "IX_Videogames_FromVideogameCollectionId",
                table: "Videogames");

            migrationBuilder.DropIndex(
                name: "IX_Videogames_GameName",
                table: "Videogames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamingPlatforms",
                table: "GamingPlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamingPlatforms_PublisherId",
                table: "GamingPlatforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_CustomFolders_FolderName",
                table: "CustomFolders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_Tags",
                table: "Videogames_Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_Publishers",
                table: "Videogames_Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_Genres",
                table: "Videogames_Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_GamingPlatforms",
                table: "Videogames_GamingPlatforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_GameModes",
                table: "Videogames_GameModes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videogames_Developers",
                table: "Videogames_Developers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomFolders_VideogameUsers",
                table: "CustomFolders_VideogameUsers");

            migrationBuilder.DropColumn(
                name: "FromVideogameCollectionId",
                table: "Videogames");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "GamingPlatforms");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Developers");

            migrationBuilder.RenameTable(
                name: "Videogames_Tags",
                newName: "VideogamesTags");

            migrationBuilder.RenameTable(
                name: "Videogames_Publishers",
                newName: "VideogamesPublishers");

            migrationBuilder.RenameTable(
                name: "Videogames_Genres",
                newName: "VideogamesGenres");

            migrationBuilder.RenameTable(
                name: "Videogames_GamingPlatforms",
                newName: "VideogamesConsoles");

            migrationBuilder.RenameTable(
                name: "Videogames_GameModes",
                newName: "VideogamesGameModes");

            migrationBuilder.RenameTable(
                name: "Videogames_Developers",
                newName: "VideogamesDevelopers");

            migrationBuilder.RenameTable(
                name: "CustomFolders_VideogameUsers",
                newName: "CustomFolderVideogameUser");

            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publishers",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "PlatformName",
                table: "GamingPlatforms",
                newName: "ConsoleName");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "GamingPlatforms",
                newName: "PublisherCompanyId");

            migrationBuilder.RenameColumn(
                name: "DeveloperName",
                table: "Developers",
                newName: "CompanyName");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_Tags_VideogameListGameId",
                table: "VideogamesTags",
                newName: "IX_VideogamesTags_VideogameListGameId");

            migrationBuilder.RenameColumn(
                name: "PublishersPublisherId",
                table: "VideogamesPublishers",
                newName: "PublishersCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_Publishers_PublishersPublisherId",
                table: "VideogamesPublishers",
                newName: "IX_VideogamesPublishers_PublishersCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_Genres_VideogameListGameId",
                table: "VideogamesGenres",
                newName: "IX_VideogamesGenres_VideogameListGameId");

            migrationBuilder.RenameColumn(
                name: "GamingPlatformsPlatformId",
                table: "VideogamesConsoles",
                newName: "GamingPlatformsConsoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_GamingPlatforms_VideogameListGameId",
                table: "VideogamesConsoles",
                newName: "IX_VideogamesConsoles_VideogameListGameId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_GameModes_VideogameListGameId",
                table: "VideogamesGameModes",
                newName: "IX_VideogamesGameModes_VideogameListGameId");

            migrationBuilder.RenameColumn(
                name: "DevelopersDeveloperId",
                table: "VideogamesDevelopers",
                newName: "DevelopersCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Videogames_Developers_GameListGameId",
                table: "VideogamesDevelopers",
                newName: "IX_VideogamesDevelopers_GameListGameId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomFolders_VideogameUsers_VideogamesUserVideogameUserId",
                table: "CustomFolderVideogameUser",
                newName: "IX_CustomFolderVideogameUser_VideogamesUserVideogameUserId");

            migrationBuilder.CreateSequence(
                name: "CompanySequence");

            migrationBuilder.AddColumn<int>(
                name: "AchievementsObtained",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AchievementsTotal",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FromVideogameCollectionId",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameFormat",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameOwnership",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePriority",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameRegion",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameStatus",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoursPlayed",
                table: "VideogameUsers",
                type: "interval",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionService",
                table: "VideogameUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Videogames",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Publishers",
                type: "integer",
                nullable: false,
                defaultValueSql: "nextval('\"CompanySequence\"')");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherCompanyId",
                table: "GamingPlatforms",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ConsoleId",
                table: "GamingPlatforms",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Developers",
                type: "integer",
                nullable: false,
                defaultValueSql: "nextval('\"CompanySequence\"')");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamingPlatforms",
                table: "GamingPlatforms",
                column: "ConsoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesTags",
                table: "VideogamesTags",
                columns: new[] { "TagsTagId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesPublishers",
                table: "VideogamesPublishers",
                columns: new[] { "GameListGameId", "PublishersCompanyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesGenres",
                table: "VideogamesGenres",
                columns: new[] { "GenresGenreId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesConsoles",
                table: "VideogamesConsoles",
                columns: new[] { "GamingPlatformsConsoleId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesGameModes",
                table: "VideogamesGameModes",
                columns: new[] { "GameModesGameModeId", "VideogameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideogamesDevelopers",
                table: "VideogamesDevelopers",
                columns: new[] { "DevelopersCompanyId", "GameListGameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomFolderVideogameUser",
                table: "CustomFolderVideogameUser",
                columns: new[] { "CustomFoldersFolderId", "VideogamesUserVideogameUserId" });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VideogameUserId = table.Column<int>(type: "integer", nullable: false),
                    ReviewContent = table.Column<string>(type: "text", nullable: false),
                    ReviewTitle = table.Column<string>(type: "text", nullable: false),
                    Vote = table.Column<double>(type: "double precision", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_FromVideogameCollectionId",
                table: "VideogameUsers",
                column: "FromVideogameCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_VideogameUsers_UserId_VideogameId",
                table: "VideogameUsers",
                columns: new[] { "UserId", "VideogameId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFolderVideogameUser_CustomFolders_CustomFoldersFolder~",
                table: "CustomFolderVideogameUser",
                column: "CustomFoldersFolderId",
                principalTable: "CustomFolders",
                principalColumn: "FolderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFolderVideogameUser_VideogameUsers_VideogamesUserVide~",
                table: "CustomFolderVideogameUser",
                column: "VideogamesUserVideogameUserId",
                principalTable: "VideogameUsers",
                principalColumn: "VideogameUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamingPlatforms_Publishers_PublisherCompanyId",
                table: "GamingPlatforms",
                column: "PublisherCompanyId",
                principalTable: "Publishers",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesConsoles_GamingPlatforms_GamingPlatformsConsoleId",
                table: "VideogamesConsoles",
                column: "GamingPlatformsConsoleId",
                principalTable: "GamingPlatforms",
                principalColumn: "ConsoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesConsoles_Videogames_VideogameListGameId",
                table: "VideogamesConsoles",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesDevelopers_Developers_DevelopersCompanyId",
                table: "VideogamesDevelopers",
                column: "DevelopersCompanyId",
                principalTable: "Developers",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesDevelopers_Videogames_GameListGameId",
                table: "VideogamesDevelopers",
                column: "GameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesGameModes_GameModes_GameModesGameModeId",
                table: "VideogamesGameModes",
                column: "GameModesGameModeId",
                principalTable: "GameModes",
                principalColumn: "GameModeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesGameModes_Videogames_VideogameListGameId",
                table: "VideogamesGameModes",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesGenres_Genres_GenresGenreId",
                table: "VideogamesGenres",
                column: "GenresGenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesGenres_Videogames_VideogameListGameId",
                table: "VideogamesGenres",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesPublishers_Publishers_PublishersCompanyId",
                table: "VideogamesPublishers",
                column: "PublishersCompanyId",
                principalTable: "Publishers",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesPublishers_Videogames_GameListGameId",
                table: "VideogamesPublishers",
                column: "GameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesTags_Tag_TagsTagId",
                table: "VideogamesTags",
                column: "TagsTagId",
                principalTable: "Tag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogamesTags_Videogames_VideogameListGameId",
                table: "VideogamesTags",
                column: "VideogameListGameId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VideogameUsers_Videogames_FromVideogameCollectionId",
                table: "VideogameUsers",
                column: "FromVideogameCollectionId",
                principalTable: "Videogames",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
