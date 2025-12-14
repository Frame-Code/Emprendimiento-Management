using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class MenuOptionsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuOpciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdRolUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOpciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuOpciones_RolUsuarios_IdRolUsuario",
                        column: x => x.IdRolUsuario,
                        principalTable: "RolUsuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_Code_Grupo",
                table: "MenuOpciones",
                columns: new[] { "Code", "Grupo" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_IdRolUsuario",
                table: "MenuOpciones",
                column: "IdRolUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuOpciones");
        }
    }
}
