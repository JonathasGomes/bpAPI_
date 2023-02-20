using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bpAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoPaiMae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomePai",
                table: "Pessoas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "NomePai",
                table: "Pessoas");
        }
    }
}
