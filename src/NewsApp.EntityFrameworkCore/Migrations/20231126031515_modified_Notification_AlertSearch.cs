using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsApp.Migrations
{
    /// <inheritdoc />
    public partial class modified_Notification_AlertSearch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppNotifications_AppAlerts_AlertId",
                table: "AppNotifications");

            migrationBuilder.AddColumn<int>(
                name: "AlertThemeId",
                table: "AppNotifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppNotifications_AlertThemeId",
                table: "AppNotifications",
                column: "AlertThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppNotifications_AppAlertsSearches_AlertId",
                table: "AppNotifications",
                column: "AlertId",
                principalTable: "AppAlertsSearches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppNotifications_AppAlertsThemes_AlertThemeId",
                table: "AppNotifications",
                column: "AlertThemeId",
                principalTable: "AppAlertsThemes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppNotifications_AppAlertsSearches_AlertId",
                table: "AppNotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_AppNotifications_AppAlertsThemes_AlertThemeId",
                table: "AppNotifications");

            migrationBuilder.DropIndex(
                name: "IX_AppNotifications_AlertThemeId",
                table: "AppNotifications");

            migrationBuilder.DropColumn(
                name: "AlertThemeId",
                table: "AppNotifications");

            migrationBuilder.AddForeignKey(
                name: "FK_AppNotifications_AppAlerts_AlertId",
                table: "AppNotifications",
                column: "AlertId",
                principalTable: "AppAlerts",
                principalColumn: "Id");
        }
    }
}
