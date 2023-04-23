using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class Invitations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Data",
                table: "Data");

            migrationBuilder.RenameTable(
                name: "Data",
                newName: "Informations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Informations",
                table: "Informations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUser = table.Column<int>(type: "int", nullable: false),
                    idPayment = table.Column<int>(type: "int", nullable: false),
                    idTemplate = table.Column<int>(type: "int", nullable: false),
                    idInformation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitations_Informations_idInformation",
                        column: x => x.idInformation,
                        principalTable: "Informations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitations_Payments_idPayment",
                        column: x => x.idPayment,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitations_Templates_idTemplate",
                        column: x => x.idTemplate,
                        principalTable: "Templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitations_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_idInformation",
                table: "Invitations",
                column: "idInformation");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_idPayment",
                table: "Invitations",
                column: "idPayment");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_idTemplate",
                table: "Invitations",
                column: "idTemplate");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_idUser",
                table: "Invitations",
                column: "idUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Informations",
                table: "Informations");

            migrationBuilder.RenameTable(
                name: "Informations",
                newName: "Data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Data",
                table: "Data",
                column: "Id");
        }
    }
}
