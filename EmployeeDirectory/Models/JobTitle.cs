using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class JobTitle
    {
        [Key]

        public int Id { get; set; }
        public string Title { get; set; }
    }
}
