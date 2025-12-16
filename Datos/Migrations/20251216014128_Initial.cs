using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargosParticipante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargosParticipante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasPremio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasPremio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cronogramas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cronogramas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facultades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultades", x => x.Id);
                });

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
                name: "Presentaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expositor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RubrosEmprendimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RubrosEmprendimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuOpciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contrasenia = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IdRolUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_RolUsuarios_IdRolUsuario",
                        column: x => x.IdRolUsuario,
                        principalTable: "RolUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emprendimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IdFacultad = table.Column<int>(type: "int", nullable: false),
                    IdRubroEmprendimiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprendimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprendimientos_Facultades_IdFacultad",
                        column: x => x.IdFacultad,
                        principalTable: "Facultades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emprendimientos_RubrosEmprendimiento_IdRubroEmprendimiento",
                        column: x => x.IdRubroEmprendimiento,
                        principalTable: "RubrosEmprendimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgendaPresentaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaPresentaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaPresentaciones_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgendaPresentaciones_Eventos_IdEvento",
                        column: x => x.IdEvento,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    HoraCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IdFoto = table.Column<int>(type: "int", nullable: true),
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: true),
                    IdCargoParticipante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participantes_CargosParticipante_IdCargoParticipante",
                        column: x => x.IdCargoParticipante,
                        principalTable: "CargosParticipante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participantes_Foto_IdFoto",
                        column: x => x.IdFoto,
                        principalTable: "Foto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultadoEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    IdCategoriaPremio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultadoEventos_CategoriasPremio_IdCategoriaPremio",
                        column: x => x.IdCategoriaPremio,
                        principalTable: "CategoriasPremio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResultadoEventos_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Votos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEmprendimiento = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votos_Emprendimientos_IdEmprendimiento",
                        column: x => x.IdEmprendimiento,
                        principalTable: "Emprendimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaPresentaciones_IdEmprendimiento",
                table: "AgendaPresentaciones",
                column: "IdEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaPresentaciones_IdEvento",
                table: "AgendaPresentaciones",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_IdEmprendimiento",
                table: "Comentarios",
                column: "IdEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_IdUsuario",
                table: "Comentarios",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EmprendimientoFotos_FotosId",
                table: "EmprendimientoFotos",
                column: "FotosId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprendimientos_IdFacultad",
                table: "Emprendimientos",
                column: "IdFacultad");

            migrationBuilder.CreateIndex(
                name: "IX_Emprendimientos_IdRubroEmprendimiento",
                table: "Emprendimientos",
                column: "IdRubroEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_Code_Grupo",
                table: "MenuOpciones",
                columns: new[] { "Code", "Grupo" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuOpciones_IdRolUsuario",
                table: "MenuOpciones",
                column: "IdRolUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_IdCargoParticipante",
                table: "Participantes",
                column: "IdCargoParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_IdEmprendimiento",
                table: "Participantes",
                column: "IdEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_IdFoto",
                table: "Participantes",
                column: "IdFoto");

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

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoEventos_IdCategoriaPremio",
                table: "ResultadoEventos",
                column: "IdCategoriaPremio");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoEventos_IdEmprendimiento",
                table: "ResultadoEventos",
                column: "IdEmprendimiento");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_Codigo",
                table: "RolUsuarios",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRolUsuario",
                table: "Usuarios",
                column: "IdRolUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_NombreUsuario",
                table: "Usuarios",
                column: "NombreUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votos_IdEmprendimiento_IdUsuario",
                table: "Votos",
                columns: new[] { "IdEmprendimiento", "IdUsuario" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votos_IdUsuario",
                table: "Votos",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaPresentaciones");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Cronogramas");

            migrationBuilder.DropTable(
                name: "EmprendimientoFotos");

            migrationBuilder.DropTable(
                name: "MenuOpciones");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Presentaciones");

            migrationBuilder.DropTable(
                name: "ResultadoEventos");

            migrationBuilder.DropTable(
                name: "Votos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "CargosParticipante");

            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "CategoriasPremio");

            migrationBuilder.DropTable(
                name: "Emprendimientos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Facultades");

            migrationBuilder.DropTable(
                name: "RubrosEmprendimiento");

            migrationBuilder.DropTable(
                name: "RolUsuarios");
        }
    }
}
