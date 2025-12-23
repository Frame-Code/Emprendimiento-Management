using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class IniqueResultadEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPremiacion",
                table: "ResultadoEventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoEventos_IdPremiacion",
                table: "ResultadoEventos",
                column: "IdPremiacion");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoEventos_Premiacion_IdPremiacion",
                table: "ResultadoEventos",
                column: "IdPremiacion",
                principalTable: "Premiacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoEventos_Premiacion_IdPremiacion",
                table: "ResultadoEventos");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoEventos_IdPremiacion",
                table: "ResultadoEventos");

            migrationBuilder.DropColumn(
                name: "IdPremiacion",
                table: "ResultadoEventos");
        }
    }
}
