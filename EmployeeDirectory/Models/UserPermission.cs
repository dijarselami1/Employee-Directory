using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class UserPermission
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; }
    }
}
