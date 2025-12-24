using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class VotoEmprendimiento1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Votos_IdEmprendimiento_IdUsuario",
                table: "Votos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Votos_IdEmprendimiento_IdUsuario",
                table: "Votos",
                columns: new[] { "IdEmprendimiento", "IdUsuario" },
                unique: true);
        }
    }
}
