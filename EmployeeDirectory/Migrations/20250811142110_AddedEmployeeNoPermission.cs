using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDirectory.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeNoPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobTitles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Email", "FirstName", "HireDate", "JobTitleId", "PermissionId", "PhoneNumber" },
                values: new object[] { 2, "ardinselami@gmail.com", "Ardin", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "389-70-264-760" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "IT" },
                    { 3, "Marketing" },
                    { 4, "R&D" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Email", "FirstName", "HireDate", "JobTitleId", "PermissionId", "PhoneNumber" },
                values: new object[] { 1, "dijarselami40@gmail.com", "Dijar", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "389-70-264-790" });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "HR Manager" },
                    { 2, "Recruiter" },
                    { 3, "Software Developer" },
                    { 4, "System Administrator" },
                    { 5, "Marketing Manager" },
                    { 6, "Content Strategist" },
                    { 7, "Research Scientist" },
                    { 8, "Product Developer" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { 1, "Employee" },
                    { 2, "Administrator" }
                });
        }
    }
}
