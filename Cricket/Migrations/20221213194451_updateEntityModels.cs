using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cricket.Migrations
{
    /// <inheritdoc />
    public partial class updateEntityModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_TeamPlayerMap_teamPlayerId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamPlayerMap_Player_PlayerEntityId",
                table: "TeamPlayerMap");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamPlayerMap_Team_TeamEntityId",
                table: "TeamPlayerMap");

            migrationBuilder.DropIndex(
                name: "IX_Team_teamPlayerId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "teamPlayerId",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "TeamEntityId",
                table: "TeamPlayerMap",
                newName: "teamEntityId");

            migrationBuilder.RenameColumn(
                name: "PlayerEntityId",
                table: "TeamPlayerMap",
                newName: "playerEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamPlayerMap_TeamEntityId",
                table: "TeamPlayerMap",
                newName: "IX_TeamPlayerMap_teamEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamPlayerMap_PlayerEntityId",
                table: "TeamPlayerMap",
                newName: "IX_TeamPlayerMap_playerEntityId");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "UmpireRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UmpireRoleMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UmpireRoleMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "UmpireRoleMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "UmpireRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UmpireRoleMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "UmpireRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UmpireRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UmpireRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "UmpireRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "UmpireRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "UmpireRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Umpire",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Umpire",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Umpire",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Umpire",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Umpire",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Umpire",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Toss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Toss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Toss",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Toss",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Toss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Toss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "teamEntityId",
                table: "TeamPlayerMap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "playerEntityId",
                table: "TeamPlayerMap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "TeamPlayerMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TeamPlayerMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TeamPlayerMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "TeamPlayerMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "TeamPlayerMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TeamPlayerMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Stadium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Stadium",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Stadium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Stadium",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Stadium",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Stadium",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Series",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Series",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Series",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Series",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "ScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PlayerRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PlayerRoleMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PlayerRoleMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "PlayerRoleMap",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "PlayerRoleMap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PlayerRoleMap",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PlayerRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PlayerRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PlayerRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "PlayerRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "PlayerRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "PlayerRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "MatchDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MatchDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MatchDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "MatchDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "MatchDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MatchDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Country",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Country",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "BowlerScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BowlerScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BowlerScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "BowlerScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "BowlerScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BowlerScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "BatsmanScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BatsmanScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BatsmanScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "BatsmanScoreBoard",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "BatsmanScoreBoard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "BatsmanScoreBoard",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "PlayerEntityTeamEntity",
                columns: table => new
                {
                    PlayerEntitiesId = table.Column<int>(type: "int", nullable: false),
                    TeamEntitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntityTeamEntity", x => new { x.PlayerEntitiesId, x.TeamEntitiesId });
                    table.ForeignKey(
                        name: "FK_PlayerEntityTeamEntity_Player_PlayerEntitiesId",
                        column: x => x.PlayerEntitiesId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntityTeamEntity_Team_TeamEntitiesId",
                        column: x => x.TeamEntitiesId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntityTeamEntity_TeamEntitiesId",
                table: "PlayerEntityTeamEntity",
                column: "TeamEntitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamPlayerMap_Player_playerEntityId",
                table: "TeamPlayerMap",
                column: "playerEntityId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamPlayerMap_Team_teamEntityId",
                table: "TeamPlayerMap",
                column: "teamEntityId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamPlayerMap_Player_playerEntityId",
                table: "TeamPlayerMap");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamPlayerMap_Team_teamEntityId",
                table: "TeamPlayerMap");

            migrationBuilder.DropTable(
                name: "PlayerEntityTeamEntity");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UmpireRoleMap");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UmpireRole");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Umpire");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Toss");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TeamPlayerMap");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Stadium");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ScoreBoard");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PlayerRoleMap");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PlayerRole");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MatchDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BowlerScoreBoard");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BatsmanScoreBoard");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BatsmanScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BatsmanScoreBoard");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "BatsmanScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "BatsmanScoreBoard");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "BatsmanScoreBoard");

            migrationBuilder.RenameColumn(
                name: "teamEntityId",
                table: "TeamPlayerMap",
                newName: "TeamEntityId");

            migrationBuilder.RenameColumn(
                name: "playerEntityId",
                table: "TeamPlayerMap",
                newName: "PlayerEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamPlayerMap_teamEntityId",
                table: "TeamPlayerMap",
                newName: "IX_TeamPlayerMap_TeamEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamPlayerMap_playerEntityId",
                table: "TeamPlayerMap",
                newName: "IX_TeamPlayerMap_PlayerEntityId");

            migrationBuilder.AlterColumn<int>(
                name: "TeamEntityId",
                table: "TeamPlayerMap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerEntityId",
                table: "TeamPlayerMap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "teamPlayerId",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Team_teamPlayerId",
                table: "Team",
                column: "teamPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_TeamPlayerMap_teamPlayerId",
                table: "Team",
                column: "teamPlayerId",
                principalTable: "TeamPlayerMap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamPlayerMap_Player_PlayerEntityId",
                table: "TeamPlayerMap",
                column: "PlayerEntityId",
                principalTable: "Player",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamPlayerMap_Team_TeamEntityId",
                table: "TeamPlayerMap",
                column: "TeamEntityId",
                principalTable: "Team",
                principalColumn: "Id");
        }
    }
}
