using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class LoginViewModel
    {
        //[Required( ErrorMessage = "Please enter Name")]
        public string? Name { get; set; }

        //[Required( ErrorMessage = "Please enter Email")]
        public string? Email{ get; set; }
    }
}
