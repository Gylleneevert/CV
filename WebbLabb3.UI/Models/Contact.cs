using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Phonenumber needed")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email needed")]
        public string Email { get; set; }
        [Required(ErrorMessage = "LinkedIn profile needed")]
        public string LinkedInUrl { get; set; }
    }
}
