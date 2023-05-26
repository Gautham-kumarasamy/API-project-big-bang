using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final333.Migrations
{
    /// <inheritdoc />
    public partial class Initia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    hotelid = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.hotelid);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    roomid = table.Column<int>(type: "int", nullable: false),
                    hotelid1 = table.Column<int>(type: "int", nullable: true),
                    roomnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    availability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.roomid);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_hotelid1",
                        column: x => x.hotelid1,
                        principalTable: "Hotels",
                        principalColumn: "hotelid");
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    reservationid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(type: "int", nullable: false),
                    roomid1 = table.Column<int>(type: "int", nullable: true),
                    checkindate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.reservationid);
                    table.ForeignKey(
                        name: "FK_reservations_Rooms_roomid1",
                        column: x => x.roomid1,
                        principalTable: "Rooms",
                        principalColumn: "roomid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservations_roomid1",
                table: "reservations",
                column: "roomid1");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_hotelid1",
                table: "Rooms",
                column: "hotelid1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
