using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oneToMany_PassengerTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Passenger_Id",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Passenger_Id",
                table: "Tickets",
                column: "Passenger_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passengers_Passenger_Id",
                table: "Tickets",
                column: "Passenger_Id",
                principalTable: "Passengers",
                principalColumn: "Passenger_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passengers_Passenger_Id",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Passenger_Id",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Passenger_Id",
                table: "Tickets");
        }
    }
}
