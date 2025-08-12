using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key
        [Required]
        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public int DepartmentId { get; set; } // Foreign Key
        //public Department Department { get; set; } = // Navigation property

        public int JobTitleId { get; set; }   // Foreign Key
        //public JobTitle JobTitle { get; set; } // Navigation property

        public byte[]? ProfilePhoto { get; set; } // Nullable

        [Required]

        public bool IsActive { get; set; }
    }
}
