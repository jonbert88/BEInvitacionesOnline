using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class MigracionUsers3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profiles_profileid",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "profileid",
                table: "Users",
                newName: "idProfile");

            migrationBuilder.RenameIndex(
                name: "IX_Users_profileid",
                table: "Users",
                newName: "IX_Users_idProfile");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profiles_idProfile",
                table: "Users",
                column: "idProfile",
                principalTable: "Profiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profiles_idProfile",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "idProfile",
                table: "Users",
                newName: "profileid");

            migrationBuilder.RenameIndex(
                name: "IX_Users_idProfile",
                table: "Users",
                newName: "IX_Users_profileid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profiles_profileid",
                table: "Users",
                column: "profileid",
                principalTable: "Profiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
