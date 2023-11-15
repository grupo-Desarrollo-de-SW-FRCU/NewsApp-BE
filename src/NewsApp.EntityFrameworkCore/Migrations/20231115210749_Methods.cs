using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class Methods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppThemes_IdentityUser_UserId",
                table: "AppThemes");

            migrationBuilder.DropIndex(
                name: "IX_AppThemes_UserId",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AppThemes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_AppThemes_UserId",
                table: "AppThemes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppThemes_IdentityUser_UserId",
                table: "AppThemes",
                column: "UserId",
                principalTable: "IdentityUser",
                principalColumn: "Id");
        }
    }
}
