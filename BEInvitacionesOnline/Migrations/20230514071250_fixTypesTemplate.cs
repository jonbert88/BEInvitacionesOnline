using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class fixTypesTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "typeTemplate",
                table: "TypeTemplates",
                newName: "typeTemp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "typeTemp",
                table: "TypeTemplates",
                newName: "typeTemplate");
        }
    }
}
