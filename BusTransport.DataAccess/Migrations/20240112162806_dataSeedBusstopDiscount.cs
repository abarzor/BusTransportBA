using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedBusstopDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Bus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    VehicleBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnRoad = table.Column<bool>(type: "bit", nullable: false),
                    BusLocationX = table.Column<double>(type: "float", nullable: false),
                    BusLocationY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Bus_Id);
                });

            migrationBuilder.CreateTable(
                name: "BusStops",
                columns: table => new
                {
                    BusStop_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusStopLocationX = table.Column<double>(type: "float", nullable: false),
                    BusStopLocationY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusStops", x => x.BusStop_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Discount_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Discount_Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driver_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginPIN = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_Id);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Passenger_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Passenger_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportCategory",
                columns: table => new
                {
                    ReportCategory_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCategory", x => x.ReportCategory_Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Report_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Report_Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Route_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Route_Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Seat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isTaken = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Seat_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Ticket_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartStop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndStop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsVaild = table.Column<bool>(type: "bit", nullable: false),
                    Passenger_Id = table.Column<int>(type: "int", nullable: false),
                    Discount_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Ticket_Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Discounts_Discount_Id",
                        column: x => x.Discount_Id,
                        principalTable: "Discounts",
                        principalColumn: "Discount_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_Passenger_Id",
                        column: x => x.Passenger_Id,
                        principalTable: "Passengers",
                        principalColumn: "Passenger_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BusStops",
                columns: new[] { "BusStop_Id", "BusStopLocationX", "BusStopLocationY", "StopName" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, "Owsianka" },
                    { 2, 0.0, 0.0, "Rosochatka" },
                    { 3, 0.0, 0.0, "Samoklęski-Kolonia Pierwsza" },
                    { 4, 0.0, 0.0, "Rozpłucie Pierwsze" },
                    { 6, 0.0, 0.0, "Niedźwiada Duża" },
                    { 7, 0.0, 0.0, "Przeginia Duchowna" },
                    { 8, 0.0, 0.0, "Swędzieniejewice" },
                    { 9, 0.0, 0.0, "Jeże" },
                    { 10, 0.0, 0.0, "Pędziwiatry" },
                    { 11, 0.0, 0.0, "Stare Pieścirogi" },
                    { 12, 0.0, 0.0, "Grabce-Towarzystwo" },
                    { 13, 0.0, 0.0, "Przedmieście Szczebrzeszyńskie" },
                    { 14, 0.0, 0.0, "Sobienie Kiełczewskie Pierwsze" },
                    { 15, 0.0, 0.0, "Stare Leśne Bohatery" }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Discount_Id", "DiscountName", "DiscountValue" },
                values: new object[,]
                {
                    { 1, "Bez zniżki", 1f },
                    { 2, "Student 40%", 0.6f },
                    { 3, "Uczeń 55%", 0.45f },
                    { 4, "Emeryt 60%", 0.4f },
                    { 5, "Poseł 100%", 0f }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Passenger_Id", "Age", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { 1, 31, "JanKofalski@gmail.com", "Jan", "test", "Kowalski" },
                    { 2, 69, "JanKofalski222@gmail.com", "Jan2", "test", "Kowalski2" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Ticket_Id", "DepartureDate", "Discount_Id", "EndStop", "IsVaild", "Passenger_Id", "SeatNumber", "StartStop", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 17, 28, 6, 31, DateTimeKind.Local).AddTicks(8495), 1, "przystanek 1", true, 1, 12, "przystanek 1", 0m },
                    { 2, new DateTime(2024, 1, 12, 17, 28, 6, 31, DateTimeKind.Local).AddTicks(8561), 2, "przystanek 1", false, 2, 12, "przystanek 1", 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Discount_Id",
                table: "Tickets",
                column: "Discount_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Passenger_Id",
                table: "Tickets",
                column: "Passenger_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "BusStops");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "ReportCategory");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}
