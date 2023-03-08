using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApicomputadoras.Migrations
{
    /// <inheritdoc />
    public partial class Tienda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Computadoras",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Precio",
                table: "Computadoras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TiendaID",
                table: "Computadoras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_tienda = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    ComputadoraID = table.Column<int>(type: "int", nullable: false),
                    ComputadorasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tiendas_Computadoras_ComputadorasId",
                        column: x => x.ComputadorasId,
                        principalTable: "Computadoras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tiendas_ComputadorasId",
                table: "Tiendas",
                column: "ComputadorasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiendas");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Computadoras");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Computadoras");

            migrationBuilder.DropColumn(
                name: "TiendaID",
                table: "Computadoras");
        }
    }
}
