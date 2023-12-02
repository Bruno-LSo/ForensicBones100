using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones100.Migrations
{
    /// <inheritdoc />
    public partial class M05CodigoAdicionadoAoInvCranio : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_InventarioCranio_Relatorios_RelatorioId",
                table: "InventarioCranio",
                column: "RelatorioId",
                principalTable: "Relatorios",
                principalColumn: "RelatorioId");
        }
    }
}
