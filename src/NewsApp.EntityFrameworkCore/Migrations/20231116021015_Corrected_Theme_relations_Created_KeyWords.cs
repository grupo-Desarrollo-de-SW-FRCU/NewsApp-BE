using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class Corrected_Theme_relations_Created_KeyWords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppKeyWords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppKeyWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppKeyWords_AppArticles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "AppArticles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AppKeyWords_AppThemes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "AppThemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppThemes_UserId",
                table: "AppThemes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppKeyWords_ArticleId",
                table: "AppKeyWords",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppKeyWords_ThemeId",
                table: "AppKeyWords",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppThemes_AbpUsers_UserId",
                table: "AppThemes",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppThemes_AbpUsers_UserId",
                table: "AppThemes");

            migrationBuilder.DropTable(
                name: "AppKeyWords");

            migrationBuilder.DropIndex(
                name: "IX_AppThemes_UserId",
                table: "AppThemes");
        }
    }
}
