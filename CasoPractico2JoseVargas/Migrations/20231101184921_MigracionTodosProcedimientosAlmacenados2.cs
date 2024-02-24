using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoPractico2JoseVargas.Migrations
{
    /// <inheritdoc />
    public partial class MigracionTodosProcedimientosAlmacenados2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "ClientesCasoPractico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientesCasoPractico",
                table: "ClientesCasoPractico",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientesCasoPractico",
                table: "ClientesCasoPractico");

            migrationBuilder.RenameTable(
                name: "ClientesCasoPractico",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");
        }
    }
}
