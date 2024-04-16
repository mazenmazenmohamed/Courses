using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class newsnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Grades_GradeId",
                table: "Semesters");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videos",
                table: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Videos",
                newName: "TblVideo");

            migrationBuilder.RenameTable(
                name: "Semesters",
                newName: "TblSemester");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "TblGrade");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "TblCourse");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_CourseId",
                table: "TblVideo",
                newName: "IX_TblVideo_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Semesters_GradeId",
                table: "TblSemester",
                newName: "IX_TblSemester_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_SemesterId",
                table: "TblCourse",
                newName: "IX_TblCourse_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_GradeId",
                table: "TblCourse",
                newName: "IX_TblCourse_GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblVideo",
                table: "TblVideo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblSemester",
                table: "TblSemester",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblGrade",
                table: "TblGrade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblCourse",
                table: "TblCourse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblCourse_TblGrade_GradeId",
                table: "TblCourse",
                column: "GradeId",
                principalTable: "TblGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblCourse_TblSemester_SemesterId",
                table: "TblCourse",
                column: "SemesterId",
                principalTable: "TblSemester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSemester_TblGrade_GradeId",
                table: "TblSemester",
                column: "GradeId",
                principalTable: "TblGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblVideo_TblCourse_CourseId",
                table: "TblVideo",
                column: "CourseId",
                principalTable: "TblCourse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblCourse_TblGrade_GradeId",
                table: "TblCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_TblCourse_TblSemester_SemesterId",
                table: "TblCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSemester_TblGrade_GradeId",
                table: "TblSemester");

            migrationBuilder.DropForeignKey(
                name: "FK_TblVideo_TblCourse_CourseId",
                table: "TblVideo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblVideo",
                table: "TblVideo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblSemester",
                table: "TblSemester");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblGrade",
                table: "TblGrade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblCourse",
                table: "TblCourse");

            migrationBuilder.RenameTable(
                name: "TblVideo",
                newName: "Videos");

            migrationBuilder.RenameTable(
                name: "TblSemester",
                newName: "Semesters");

            migrationBuilder.RenameTable(
                name: "TblGrade",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "TblCourse",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_TblVideo_CourseId",
                table: "Videos",
                newName: "IX_Videos_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_TblSemester_GradeId",
                table: "Semesters",
                newName: "IX_Semesters_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_TblCourse_SemesterId",
                table: "Courses",
                newName: "IX_Courses_SemesterId");

            migrationBuilder.RenameIndex(
                name: "IX_TblCourse_GradeId",
                table: "Courses",
                newName: "IX_Courses_GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videos",
                table: "Videos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Grades_GradeId",
                table: "Courses",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Grades_GradeId",
                table: "Semesters",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Courses_CourseId",
                table: "Videos",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
