using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class CreatedNotificationsNotificationAppAndNotificationMail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessError");

            migrationBuilder.DropTable(
                name: "AppAccesses");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "AppArticles");

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

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AppErrors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ExceptionName",
                table: "AppErrors",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AppNotificationsApp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UrlToImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNotificationsApp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppNotificationsMail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNotificationsMail", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppNotificationsApp");

            migrationBuilder.DropTable(
                name: "AppNotificationsMail");

            migrationBuilder.DropColumn(
                name: "ExceptionName",
                table: "AppErrors");

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

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "AppErrors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "ArticleId",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
