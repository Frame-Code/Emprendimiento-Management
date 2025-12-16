using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionParticipanteFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmprendimientoFotos_Foto_FotosId",
                table: "EmprendimientoFotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Foto_IdFoto",
                table: "Participantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Foto",
                table: "Foto");

            migrationBuilder.RenameTable(
                name: "Foto",
                newName: "Fotos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fotos",
                table: "Fotos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmprendimientoFotos_Fotos_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId",
                principalTable: "Fotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Fotos_IdFoto",
                table: "Participantes",
                column: "IdFoto",
                principalTable: "Fotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmprendimientoFotos_Fotos_FotosId",
                table: "EmprendimientoFotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Fotos_IdFoto",
                table: "Participantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fotos",
                table: "Fotos");

            migrationBuilder.RenameTable(
                name: "Fotos",
                newName: "Foto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foto",
                table: "Foto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmprendimientoFotos_Foto_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId",
                principalTable: "Foto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Foto_IdFoto",
                table: "Participantes",
                column: "IdFoto",
                principalTable: "Foto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
