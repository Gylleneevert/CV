using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebbLabb3.UI.Data.Migrations
{
    /// <inheritdoc />
    public partial class tableUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Courses_CourseId",
                table: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Education_CourseId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "Task",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Education");

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EducationId",
                table: "Courses",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Education_EducationId",
                table: "Courses",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Education_EducationId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_EducationId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "About");

            migrationBuilder.AddColumn<string>(
                name: "Task",
                table: "Experience",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Education",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Education_CourseId",
                table: "Education",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Courses_CourseId",
                table: "Education",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
