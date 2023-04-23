using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class Template : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoPlantilla",
                table: "TiposPlantilla",
                newName: "typeTemplate");

            migrationBuilder.CreateTable(
                name: "Plantillass",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTypeTemplate = table.Column<int>(type: "int", nullable: false),
                    nombrePlantilla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentCero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentSix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentSeven = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentEight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    divContentFooter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantillass", x => x.id);
                    table.ForeignKey(
                        name: "FK_Plantillass_TiposPlantilla_idTypeTemplate",
                        column: x => x.idTypeTemplate,
                        principalTable: "TiposPlantilla",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plantillass_idTypeTemplate",
                table: "Plantillass",
                column: "idTypeTemplate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plantillass");

            migrationBuilder.RenameColumn(
                name: "typeTemplate",
                table: "TiposPlantilla",
                newName: "tipoPlantilla");
        }
    }
}
