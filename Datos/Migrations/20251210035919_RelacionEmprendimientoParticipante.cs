using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionEmprendimientoParticipante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Emprendimientos_IdEmprendimiento",
                table: "Participantes");

            migrationBuilder.AlterColumn<int>(
                name: "IdEmprendimiento",
                table: "Participantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Emprendimientos_IdEmprendimiento",
                table: "Participantes",
                column: "IdEmprendimiento",
                principalTable: "Emprendimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Emprendimientos_IdEmprendimiento",
                table: "Participantes");

            migrationBuilder.AlterColumn<int>(
                name: "IdEmprendimiento",
                table: "Participantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Emprendimientos_IdEmprendimiento",
                table: "Participantes",
                column: "IdEmprendimiento",
                principalTable: "Emprendimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
