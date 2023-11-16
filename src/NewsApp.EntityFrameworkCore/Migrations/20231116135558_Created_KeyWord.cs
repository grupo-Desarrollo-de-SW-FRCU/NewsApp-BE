using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class Created_KeyWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppThemes_IdentityUser_UserId",
                table: "AppThemes");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "AppThemes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AppKeyWords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppKeyWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppKeyWords_AppThemes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "AppThemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppKeyWords_ThemeId",
                table: "AppKeyWords",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppThemes_AbpUsers_UserId",
                table: "AppThemes",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppThemes_AbpUsers_UserId",
                table: "AppThemes");

            migrationBuilder.DropTable(
                name: "AppKeyWords");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppThemes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AppThemes_IdentityUser_UserId",
                table: "AppThemes",
                column: "UserId",
                principalTable: "IdentityUser",
                principalColumn: "Id");
        }
    }
}
