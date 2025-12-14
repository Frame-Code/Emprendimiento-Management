using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class FotosEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoPath",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "LogoPath",
                table: "Emprendimientos");

            migrationBuilder.AddColumn<int>(
                name: "IdFoto",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", maxLength: 6000, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmprendimientoFotos",
                columns: table => new
                {
                    EmprendimientosId = table.Column<int>(type: "int", nullable: false),
                    FotosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprendimientoFotos", x => new { x.EmprendimientosId, x.FotosId });
                    table.ForeignKey(
                        name: "FK_EmprendimientoFotos_Emprendimientos_EmprendimientosId",
                        column: x => x.EmprendimientosId,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprendimientoFotos_Foto_FotosId",
                        column: x => x.FotosId,
                        principalTable: "Foto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_IdFoto",
                table: "Participantes",
                column: "IdFoto");

            migrationBuilder.CreateIndex(
                name: "IX_EmprendimientoFotos_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Foto_IdFoto",
                table: "Participantes",
                column: "IdFoto",
                principalTable: "Foto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Foto_IdFoto",
                table: "Participantes");

            migrationBuilder.DropTable(
                name: "EmprendimientoFotos");

            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_IdFoto",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "IdFoto",
                table: "Participantes");

            migrationBuilder.AddColumn<string>(
                name: "FotoPath",
                table: "Participantes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoPath",
                table: "Emprendimientos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }
    }
}
