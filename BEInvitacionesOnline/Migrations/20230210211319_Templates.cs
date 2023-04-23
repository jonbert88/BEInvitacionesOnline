using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class Templates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantillass_TiposPlantilla_idTypeTemplate",
                table: "Plantillass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposPlantilla",
                table: "TiposPlantilla");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plantillass",
                table: "Plantillass");

            migrationBuilder.RenameTable(
                name: "TiposPlantilla",
                newName: "TypeTemplates");

            migrationBuilder.RenameTable(
                name: "Plantillass",
                newName: "Templates");

            migrationBuilder.RenameIndex(
                name: "IX_Plantillass_idTypeTemplate",
                table: "Templates",
                newName: "IX_Templates_idTypeTemplate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeTemplates",
                table: "TypeTemplates",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Templates",
                table: "Templates",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_TypeTemplates_idTypeTemplate",
                table: "Templates",
                column: "idTypeTemplate",
                principalTable: "TypeTemplates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Templates_TypeTemplates_idTypeTemplate",
                table: "Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeTemplates",
                table: "TypeTemplates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Templates",
                table: "Templates");

            migrationBuilder.RenameTable(
                name: "TypeTemplates",
                newName: "TiposPlantilla");

            migrationBuilder.RenameTable(
                name: "Templates",
                newName: "Plantillass");

            migrationBuilder.RenameIndex(
                name: "IX_Templates_idTypeTemplate",
                table: "Plantillass",
                newName: "IX_Plantillass_idTypeTemplate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposPlantilla",
                table: "TiposPlantilla",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plantillass",
                table: "Plantillass",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plantillass_TiposPlantilla_idTypeTemplate",
                table: "Plantillass",
                column: "idTypeTemplate",
                principalTable: "TiposPlantilla",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
