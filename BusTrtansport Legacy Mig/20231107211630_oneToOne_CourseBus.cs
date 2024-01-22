using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oneToOne_CourseBus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Bus_Id",
                table: "Buses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Buses_Courses_Bus_Id",
                table: "Buses",
                column: "Bus_Id",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buses_Courses_Bus_Id",
                table: "Buses");

            migrationBuilder.AlterColumn<int>(
                name: "Bus_Id",
                table: "Buses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
