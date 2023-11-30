using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones100.Migrations
{
    /// <inheritdoc />
    public partial class M02Estimativa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CalculoEstimativaSexo",
                table: "MarcadoresCranio",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalculoEstimativaSexo",
                table: "MarcadoresCranio");
        }
    }
}
