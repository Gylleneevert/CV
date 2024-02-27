using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Projects
    {
        public int Id { get; set; }

        [Required]
        public string ProjectName { get; set; }

        public string Description { get; set; }
        public string GithubUrl { get; set; }
    }
}
