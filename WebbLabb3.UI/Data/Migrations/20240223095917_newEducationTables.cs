using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebbLabb3.UI.Data.Migrations
{
    /// <inheritdoc />
    public partial class newEducationTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Courses",
                type: "int",
                nullable: true);

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
    }
}
