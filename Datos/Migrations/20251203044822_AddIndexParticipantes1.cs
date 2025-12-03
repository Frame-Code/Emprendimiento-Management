using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexParticipantes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participantes_NumeroIdentificacion_NumeroTelefono",
                table: "Participantes");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_NumeroIdentificacion",
                table: "Participantes",
                column: "NumeroIdentificacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_NumeroTelefono",
                table: "Participantes",
                column: "NumeroTelefono",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participantes_NumeroIdentificacion",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_NumeroTelefono",
                table: "Participantes");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_NumeroIdentificacion_NumeroTelefono",
                table: "Participantes",
                columns: new[] { "NumeroIdentificacion", "NumeroTelefono" },
                unique: true);
        }
    }
}
