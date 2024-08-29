using System.ComponentModel.DataAnnotations;

namespace AgeArticle.Models
{
    public class SurveyResponse
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public int? Age { get; set; }
        public string? Agree { get; set; }
        public string? Comment { get; set; }
    }
}
