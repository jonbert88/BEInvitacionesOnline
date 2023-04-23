using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    /// <inheritdoc />
    public partial class InforationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    narrativeOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeSix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeSeven = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    narrativeEight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameOne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameTwo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameThree = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameFour = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameFive = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameSix = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameSeven = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nameEight = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    dateEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateEventTwo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    startTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    endTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    stratTimeTwo = table.Column<TimeSpan>(type: "time", nullable: false),
                    endTimeTwo = table.Column<TimeSpan>(type: "time", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addressTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addressThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageThree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageFour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageFive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageSix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageSeven = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlImageEight = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data");
        }
    }
}
