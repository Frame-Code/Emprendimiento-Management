using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class ForzarColumnaFotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmprendimientoFotos_Emprendimientos_EmprendimientosId",
                table: "EmprendimientoFotos");

            migrationBuilder.DropForeignKey(
                name: "FK_EmprendimientoFotos_Fotos_FotosId",
                table: "EmprendimientoFotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmprendimientoFotos",
                table: "EmprendimientoFotos");

            migrationBuilder.DropIndex(
                name: "IX_EmprendimientoFotos_FotosId",
                table: "EmprendimientoFotos");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Fotos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "Fotos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<int>(
                name: "IdEmprendimiento",
                table: "Fotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmprendimientoFotos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmprendimientoFotos",
                table: "EmprendimientoFotos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComentariosFoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FotoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentariosFoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComentariosFoto_Fotos_FotoId",
                        column: x => x.FotoId,
                        principalTable: "Fotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_IdEmprendimiento",
                table: "Fotos",
                column: "IdEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosFoto_FotoId",
                table: "ComentariosFoto",
                column: "FotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fotos_Emprendimientos_IdEmprendimiento",
                table: "Fotos",
                column: "IdEmprendimiento",
                principalTable: "Emprendimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fotos_Emprendimientos_IdEmprendimiento",
                table: "Fotos");

            migrationBuilder.DropTable(
                name: "ComentariosFoto");

            migrationBuilder.DropIndex(
                name: "IX_Fotos_IdEmprendimiento",
                table: "Fotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmprendimientoFotos",
                table: "EmprendimientoFotos");

            migrationBuilder.DropColumn(
                name: "IdEmprendimiento",
                table: "Fotos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmprendimientoFotos");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Fotos",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "Fotos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmprendimientoFotos",
                table: "EmprendimientoFotos",
                columns: new[] { "EmprendimientosId", "FotosId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmprendimientoFotos_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmprendimientoFotos_Emprendimientos_EmprendimientosId",
                table: "EmprendimientoFotos",
                column: "EmprendimientosId",
                principalTable: "Emprendimientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmprendimientoFotos_Fotos_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId",
                principalTable: "Fotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
