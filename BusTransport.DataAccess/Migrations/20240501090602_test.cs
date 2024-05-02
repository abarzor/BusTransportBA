using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 5, 1, 11, 6, 1, 153, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 5, 1, 11, 6, 1, 153, DateTimeKind.Local).AddTicks(2266));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 28, 21, 14, 32, 672, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 28, 21, 14, 32, 672, DateTimeKind.Local).AddTicks(7202));
        }
    }
}
