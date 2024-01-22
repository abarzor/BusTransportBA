using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oneToMany_TicketCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Course_Id",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Course_Id",
                table: "Tickets",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Courses_Course_Id",
                table: "Tickets",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Courses_Course_Id",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Course_Id",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Course_Id",
                table: "Tickets");
        }
    }
}
