using System.ComponentModel.DataAnnotations;

namespace Mission8_Team2_5.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
