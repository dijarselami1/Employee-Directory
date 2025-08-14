using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class UserAccount 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; } 
        [Required]

        public string Password { get; set; }
        [Required]

        public int PermissionID { get; set; }
        [Required]
        public int EmployeeID{ get; set; }
    }
}
