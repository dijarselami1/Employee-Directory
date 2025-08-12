using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeDirectory.Migrations
{
    /// <inheritdoc />
    public partial class UsersAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    ProfilePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "FirstName", "HireDate", "IsActive", "JobTitleId", "LastName", "PhoneNumber", "ProfilePhoto" },
                values: new object[,]
                {
                    { 1, 1, "dijarselami40@gmail.com", "Dijar", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "Selami", "389-70-264-790", null },
                    { 2, 2, "ardinselami@gmail.com", "Ardin", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Selami", "389-70-264-760", null },
                    { 3, 2, "mina@gmail.com", "Mina", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, "Selami", "389-70-264-776", null }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmployeeID", "Password", "PermissionID", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "dijarS", 2, "dijarS" },
                    { 2, 2, "ardinS", 1, "ardinS" },
                    { 3, 3, "minaS", 1, "minaS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
