using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones100.Migrations
{
    /// <inheritdoc />
    public partial class M07AlteraçãoInventariosCranioControllers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventarioCranio_Relatorios_RelatorioId",
                table: "InventarioCranio");

            migrationBuilder.AlterColumn<int>(
                name: "RelatorioId",
                table: "InventarioCranio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "RelatorioCodigo",
                table: "InventarioCranio",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.DropColumn(
                name: "RelatorioCodigo",
                table: "InventarioCranio");

            migrationBuilder.AlterColumn<int>(
                name: "RelatorioId",
                table: "InventarioCranio",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioCranio_Relatorios_RelatorioId",
                table: "InventarioCranio",
                column: "RelatorioId",
                principalTable: "Relatorios",
                principalColumn: "RelatorioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
