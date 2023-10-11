using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class createbusqueda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBusquedas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cadenaBuscada = table.Column<string>(name: "cadena_Buscada", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NombreUsuario = table.Column<string>(name: "Nombre_Usuario", type: "nvarchar(max)", nullable: true),
                    FechaBusqueda = table.Column<string>(name: "Fecha_Busqueda", type: "nvarchar(max)", nullable: true),
                    CantidadResultados = table.Column<int>(name: "Cantidad_Resultados", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBusquedas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBusquedas");
        }
    }
}
