using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class removed_articles_from_search : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppArticles_AppSearches_SearchId",
                table: "AppArticles");

            migrationBuilder.DropIndex(
                name: "IX_AppArticles_SearchId",
                table: "AppArticles");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "AppArticles");

            migrationBuilder.DropColumn(
                name: "SearchId",
                table: "AppArticles");

            migrationBuilder.AlterColumn<string>(
                name: "UrlToImage",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SourceName",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlToImage",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SourceName",
                table: "AppArticles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "AppArticles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SearchId",
                table: "AppArticles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppArticles_SearchId",
                table: "AppArticles",
                column: "SearchId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppArticles_AppSearches_SearchId",
                table: "AppArticles",
                column: "SearchId",
                principalTable: "AppSearches",
                principalColumn: "Id");
        }
    }
}
