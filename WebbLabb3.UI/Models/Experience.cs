using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Company needed")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Title needed")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year needed")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Description needed")]
        public string Description { get; set; }
    }
}
