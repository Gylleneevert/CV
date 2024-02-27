using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "School needed")]
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "Title needed")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year needed")]
        public string Year { get; set; }
    }
}
