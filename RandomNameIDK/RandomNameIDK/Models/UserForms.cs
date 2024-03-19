using System.ComponentModel.DataAnnotations;

namespace RandomNameIDK.Models
{
    public class UserForm
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
