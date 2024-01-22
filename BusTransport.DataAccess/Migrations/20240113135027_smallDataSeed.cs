using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class smallDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusStops",
                columns: new[] { "BusStop_Id", "BusStopLocationX", "BusStopLocationY", "StopName" },
                values: new object[,]
                {
                    { 16, 0.0, 0.0, "Warszawa" },
                    { 17, 0.0, 0.0, "Kętrzyn" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 13, 14, 50, 26, 137, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 13, 14, 50, 26, 137, DateTimeKind.Local).AddTicks(1613));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusStops",
                keyColumn: "BusStop_Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BusStops",
                keyColumn: "BusStop_Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 12, 17, 28, 6, 31, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 12, 17, 28, 6, 31, DateTimeKind.Local).AddTicks(8561));
        }
    }
}
