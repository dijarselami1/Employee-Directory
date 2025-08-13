using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; } //Primary
        public string Name { get; set; }
    }
}
