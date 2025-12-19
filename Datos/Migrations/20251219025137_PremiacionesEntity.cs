using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class PremiacionesEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Premiacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    FechaInicioPremiacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinPremiacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premiacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmprendimientoPremiacion",
                columns: table => new
                {
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    IdPremiacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprendimientoPremiacion", x => new { x.IdEmprendimiento, x.IdPremiacion });
                    table.ForeignKey(
                        name: "FK_EmprendimientoPremiacion_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprendimientoPremiacion_Premiacion_IdPremiacion",
                        column: x => x.IdPremiacion,
                        principalTable: "Premiacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VotoPremiacion",
                columns: table => new
                {
                    IdVoto = table.Column<int>(type: "int", nullable: false),
                    IdPremiacion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotoPremiacion", x => new { x.IdVoto, x.IdPremiacion });
                    table.ForeignKey(
                        name: "FK_VotoPremiacion_Premiacion_IdPremiacion",
                        column: x => x.IdPremiacion,
                        principalTable: "Premiacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VotoPremiacion_Votos_IdVoto",
                        column: x => x.IdVoto,
                        principalTable: "Votos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmprendimientoPremiacion_IdPremiacion",
                table: "EmprendimientoPremiacion",
                column: "IdPremiacion");

            migrationBuilder.CreateIndex(
                name: "IX_Premiacion_FechaInicioPremiacion_FechaFinPremiacion",
                table: "Premiacion",
                columns: new[] { "FechaInicioPremiacion", "FechaFinPremiacion" });

            migrationBuilder.CreateIndex(
                name: "IX_VotoPremiacion_IdPremiacion",
                table: "VotoPremiacion",
                column: "IdPremiacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprendimientoPremiacion");

            migrationBuilder.DropTable(
                name: "VotoPremiacion");

            migrationBuilder.DropTable(
                name: "Premiacion");
        }
    }
}
