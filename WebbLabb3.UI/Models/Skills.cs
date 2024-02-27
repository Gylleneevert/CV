using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Skills
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Skill needed")]
        public string SkillName { get; set; }

        public string Description { get; set; }
    }
}
