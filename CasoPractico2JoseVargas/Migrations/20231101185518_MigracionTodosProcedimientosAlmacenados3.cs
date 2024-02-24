using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CasoPractico2JoseVargas.Migrations
{
    /// <inheritdoc />
    public partial class MigracionTodosProcedimientosAlmacenados3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesCasoPractico");

            migrationBuilder.CreateTable(
                name: "Personas_Profesor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preferencias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_Profesor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personas_Profesor",
                columns: new[] { "Id", "Apellidos", "Cedula", "Edad", "Nombre", "Preferencias" },
                values: new object[,]
                {
                    { 1, "Vargas", "115180942215", 31, "Jose", "Preferencias uno uno uno" },
                    { 2, "Prado", "1168409454", 26, "Jos", "Preferencias dos dos dos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas_Profesor");

            migrationBuilder.CreateTable(
                name: "ClientesCasoPractico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preferencias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesCasoPractico", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ClientesCasoPractico",
                columns: new[] { "Id", "Apellidos", "Cedula", "Edad", "Nombre", "Preferencias" },
                values: new object[,]
                {
                    { 1, "Vargas", "115180942215", 31, "Jose", "Preferencias uno uno uno" },
                    { 2, "Prado", "1168409454", 26, "Jos", "Preferencias dos dos dos" }
                });
        }
    }
}
