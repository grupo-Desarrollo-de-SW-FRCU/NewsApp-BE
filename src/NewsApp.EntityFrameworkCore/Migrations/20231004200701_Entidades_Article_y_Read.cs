using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class EntidadesArticleyRead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechayHoraIngreso",
                table: "AppAccesses",
                newName: "FechayHoraIngreso");

            migrationBuilder.RenameColumn(
                name: "fechayHoraEgreso",
                table: "AppAccesses",
                newName: "FechayHoraEgreso");

            migrationBuilder.CreateTable(
                name: "AccessError",
                columns: table => new
                {
                    AccessesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ErrorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessError", x => new { x.AccessesId, x.ErrorsId });
                    table.ForeignKey(
                        name: "FK_AccessError_AppAccesses_AccessesId",
                        column: x => x.AccessesId,
                        principalTable: "AppAccesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessError_AppErrors_ErrorsId",
                        column: x => x.ErrorsId,
                        principalTable: "AppErrors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppArticles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlToImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idiom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppArticles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppReads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    likeada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReads", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessError_ErrorsId",
                table: "AccessError",
                column: "ErrorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessError");

            migrationBuilder.DropTable(
                name: "AppArticles");

            migrationBuilder.DropTable(
                name: "AppReads");

            migrationBuilder.RenameColumn(
                name: "FechayHoraIngreso",
                table: "AppAccesses",
                newName: "fechayHoraIngreso");

            migrationBuilder.RenameColumn(
                name: "FechayHoraEgreso",
                table: "AppAccesses",
                newName: "fechayHoraEgreso");
        }
    }
}
