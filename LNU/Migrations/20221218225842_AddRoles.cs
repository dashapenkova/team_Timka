using Microsoft.EntityFrameworkCore.Migrations;

namespace LNU.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Person",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OfficeAssignment",
                newName: "OfficeAssignment",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                newName: "Enrollment",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Department",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "CourseAssignment",
                newName: "CourseAssignment",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Course",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims",
                newSchema: "Identity");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "d62afc39-9044-4a87-a3d6-bd0de4ae9e4d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "d9644d1e-916d-4265-b7f1-e4a2fc2f86d1", "LnuUser", "LNUUSER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "Identity",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "OfficeAssignment",
                schema: "Identity",
                newName: "OfficeAssignment");

            migrationBuilder.RenameTable(
                name: "Enrollment",
                schema: "Identity",
                newName: "Enrollment");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "Identity",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "CourseAssignment",
                schema: "Identity",
                newName: "CourseAssignment");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "Identity",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "Identity",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "Identity",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "Identity",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "Identity",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "Identity",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "Identity",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "Identity",
                newName: "AspNetRoleClaims");
        }
    }
}
