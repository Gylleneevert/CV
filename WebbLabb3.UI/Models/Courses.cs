using System.ComponentModel.DataAnnotations;

namespace WebbLabb3.UI.Models
{
    public class Courses
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Course name needed")]
        public string CourseName { get; set; }
    }
}
