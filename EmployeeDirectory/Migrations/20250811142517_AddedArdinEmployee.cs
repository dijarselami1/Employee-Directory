using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDirectory.Migrations
{
    /// <inheritdoc />
    public partial class AddedArdinEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "FirstName", "HireDate", "IsActive", "JobTitleId", "LastName", "PermissionId", "PhoneNumber", "ProfilePhoto" },
                values: new object[] { 2, 2, "ardinselami@gmail.com", "Ardin", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Selami", 1, "389-70-264-760", null });

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

        /// <inheritdoc />
      
    }
}
