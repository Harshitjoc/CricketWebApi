using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cricket.Migrations
{
    /// <inheritdoc />
    public partial class updateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerCount",
                table: "TeamPlayerMap",
                newName: "Counter");

            migrationBuilder.AddColumn<int>(
                name: "PlayerCount",
                table: "MatchDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerCount",
                table: "MatchDetail");

            migrationBuilder.RenameColumn(
                name: "Counter",
                table: "TeamPlayerMap",
                newName: "PlayerCount");
        }
    }
}
