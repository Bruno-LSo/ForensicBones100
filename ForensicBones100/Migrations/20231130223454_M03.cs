using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones100.Migrations
{
    /// <inheritdoc />
    public partial class M03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelatorioId",
                table: "InventarioCranio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InventarioCranio_RelatorioId",
                table: "InventarioCranio",
                column: "RelatorioId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioCranio_Relatorios_RelatorioId",
                table: "InventarioCranio",
                column: "RelatorioId",
                principalTable: "Relatorios",
                principalColumn: "RelatorioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventarioCranio_Relatorios_RelatorioId",
                table: "InventarioCranio");

            migrationBuilder.DropIndex(
                name: "IX_InventarioCranio_RelatorioId",
                table: "InventarioCranio");

            migrationBuilder.DropColumn(
                name: "RelatorioId",
                table: "InventarioCranio");
        }
    }
}
