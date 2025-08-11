using EmployeeDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Models.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }
    //creating tables in the database
    public DbSet<UserPermission> Permissions { get; set; }
    public DbSet<Employee> Employees { get; set; } 
    public DbSet<JobTitle> JobTitles { get; set; }
    public DbSet<Department> Departments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserPermission>().HasData(
            new UserPermission { Id = 1, Position="Employee" },
            new UserPermission { Id = 2, Position= "Administrator" }
            );

        modelBuilder.Entity<JobTitle>().HasData(
            new JobTitle { Id = 1, Title = "HR Manager" },
            new JobTitle { Id = 2, Title = "Recruiter" },
            new JobTitle { Id = 3, Title = "Software Developer" },
            new JobTitle { Id = 4, Title = "System Administrator" },
            new JobTitle { Id = 5, Title = "Marketing Manager" },
            new JobTitle { Id = 6, Title = "Content Strategist" },
            new JobTitle { Id = 7, Title = "Research Scientist" },
            new JobTitle { Id = 8, Title = "Product Developer" }
        );

        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1,Name="HR" },
            new Department { Id = 2,Name= "IT" },
            new Department { Id = 3,Name= "Marketing" },
            new Department { Id = 4,Name= "R&D" }
        );
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                FirstName = "Dijar",
                LastName = "Selami",
                Email = "dijarselami40@gmail.com",
                PhoneNumber = "389-70-264-790",
                HireDate = new DateTime(2020, 1, 15),
                DepartmentId = 1,
                JobTitleId = 1,
                PermissionId = 2,
                ProfilePhoto = null,
                IsActive = true
            }
        );
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 2,
                FirstName = "Ardin",
                LastName = "Selami",
                Email = "ardinselami@gmail.com",
                PhoneNumber = "389-70-264-760",
                HireDate = new DateTime(2025, 1, 15),
                DepartmentId = 2,
                JobTitleId = 3,
                PermissionId = 1,
                ProfilePhoto = null,
                IsActive = true
            }
        );
    }
}
