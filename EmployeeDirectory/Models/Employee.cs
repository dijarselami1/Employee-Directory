using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; } // Primary Key
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; } 

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public int DepartmentId { get; set; } // Foreign Key
        //public Department Department { get; set; } = // Navigation property
        [Required]
        public int JobTitleId { get; set; }   // Foreign Key
        //public JobTitle JobTitle { get; set; } // Navigation property

        public byte[]? ProfilePhoto { get; set; }  // Nullable

        [Required]

        public bool IsActive { get; set; }
    }
}
