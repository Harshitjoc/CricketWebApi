using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cricket.Migrations
{
    /// <inheritdoc />
    public partial class CricketDataCricketContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stadium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Timezone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadium", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stadium_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Umpire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umpire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Umpire_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlayerRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamA_PlayerRole_PlayerRoleId",
                        column: x => x.PlayerRoleId,
                        principalTable: "PlayerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamA_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlayerRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamB_PlayerRole_PlayerRoleId",
                        column: x => x.PlayerRoleId,
                        principalTable: "PlayerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamB_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UmpireRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UmpireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UmpireRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UmpireRole_Umpire_UmpireId",
                        column: x => x.UmpireId,
                        principalTable: "Umpire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamAId = table.Column<int>(type: "int", nullable: true),
                    TeamBId = table.Column<int>(type: "int", nullable: true),
                    StadiumId = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false),
                    TossId = table.Column<int>(type: "int", nullable: false),
                    UmpireRoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchDetail_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchDetail_Stadium_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadium",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchDetail_TeamA_TeamAId",
                        column: x => x.TeamAId,
                        principalTable: "TeamA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchDetail_TeamB_TeamBId",
                        column: x => x.TeamBId,
                        principalTable: "TeamB",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MatchDetail_Toss_TossId",
                        column: x => x.TossId,
                        principalTable: "Toss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchDetail_UmpireRole_UmpireRoleId",
                        column: x => x.UmpireRoleId,
                        principalTable: "UmpireRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_SeriesId",
                table: "MatchDetail",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_StadiumId",
                table: "MatchDetail",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_TeamAId",
                table: "MatchDetail",
                column: "TeamAId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_TeamBId",
                table: "MatchDetail",
                column: "TeamBId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_TossId",
                table: "MatchDetail",
                column: "TossId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchDetail_UmpireRoleId",
                table: "MatchDetail",
                column: "UmpireRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CountryId",
                table: "Player",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stadium_CountryId",
                table: "Stadium",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamA_PlayerId",
                table: "TeamA",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamA_PlayerRoleId",
                table: "TeamA",
                column: "PlayerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamB_PlayerId",
                table: "TeamB",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamB_PlayerRoleId",
                table: "TeamB",
                column: "PlayerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Umpire_CountryId",
                table: "Umpire",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UmpireRole_UmpireId",
                table: "UmpireRole",
                column: "UmpireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchDetail");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Stadium");

            migrationBuilder.DropTable(
                name: "TeamA");

            migrationBuilder.DropTable(
                name: "TeamB");

            migrationBuilder.DropTable(
                name: "Toss");

            migrationBuilder.DropTable(
                name: "UmpireRole");

            migrationBuilder.DropTable(
                name: "PlayerRole");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Umpire");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
