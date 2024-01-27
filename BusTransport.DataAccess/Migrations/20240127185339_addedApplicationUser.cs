using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Surname",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 27, 19, 53, 39, 154, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 27, 19, 53, 39, 154, DateTimeKind.Local).AddTicks(558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 1,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 27, 19, 44, 11, 883, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Ticket_Id",
                keyValue: 2,
                column: "DepartureDate",
                value: new DateTime(2024, 1, 27, 19, 44, 11, 883, DateTimeKind.Local).AddTicks(2126));
        }
    }
}
