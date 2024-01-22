using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusTransport.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oneToOne_CourseRoute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Route_Id",
                table: "Routes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Courses_Route_Id",
                table: "Routes",
                column: "Route_Id",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Courses_Route_Id",
                table: "Routes");

            migrationBuilder.AlterColumn<int>(
                name: "Route_Id",
                table: "Routes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
