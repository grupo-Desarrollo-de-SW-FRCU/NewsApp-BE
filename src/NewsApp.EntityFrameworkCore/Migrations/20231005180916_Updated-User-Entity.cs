using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: " IdiomPrefered",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "English");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: " IdiomPrefered",
                table: "AbpUsers");
        }
    }
}
