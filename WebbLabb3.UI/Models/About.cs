using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You need a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need a description")]

        public string Description { get; set; }
    }
}
