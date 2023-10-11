using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUsersEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessError");

            migrationBuilder.DropTable(
                name: "AppAccesses");

            migrationBuilder.RenameColumn(
                name: "likeada",
                table: "AppReads",
                newName: "Likeada");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AppErrors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "errorCode",
                table: "AppErrors",
                newName: "ErrorCode");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "AppErrors",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "AppArticles",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: " IdiomPrefered",
                table: "AbpUsers",
                newName: "IdiomPrefered");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "AppErrors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UrlToImage",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Idiom",
                table: "AppArticles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedAt",
                table: "AppArticles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "AppErrors");

            migrationBuilder.DropColumn(
                name: "PublishedAt",
                table: "AppArticles");

            migrationBuilder.RenameColumn(
                name: "Likeada",
                table: "AppReads",
                newName: "likeada");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AppErrors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ErrorCode",
                table: "AppErrors",
                newName: "errorCode");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AppErrors",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "AppArticles",
                newName: "ArticleId");

            migrationBuilder.RenameColumn(
                name: "IdiomPrefered",
                table: "AbpUsers",
                newName: " IdiomPrefered");

            migrationBuilder.AlterColumn<string>(
                name: "UrlToImage",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Idiom",
                table: "AppArticles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AppAccesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechayHoraEgreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechayHoraIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAccesses", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AccessError_ErrorsId",
                table: "AccessError",
                column: "ErrorsId");
        }
    }
}
