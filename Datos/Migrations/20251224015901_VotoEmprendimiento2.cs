using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class VotoEmprendimiento2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votos_IdEmprendimiento",
                table: "Votos");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_IdEmprendimiento",
                table: "Votos",
                column: "IdEmprendimiento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votos_IdEmprendimiento",
                table: "Votos");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_IdEmprendimiento",
                table: "Votos",
                column: "IdEmprendimiento",
                unique: true);
        }
    }
}
