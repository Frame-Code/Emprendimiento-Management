using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexParticipantes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Participantes_NumeroIdentificacion_NumeroTelefono",
                table: "Participantes",
                columns: new[] { "NumeroIdentificacion", "NumeroTelefono" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Participantes_NumeroIdentificacion_NumeroTelefono",
                table: "Participantes");
        }
    }
}
