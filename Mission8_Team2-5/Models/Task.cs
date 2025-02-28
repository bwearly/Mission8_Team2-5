using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission8_Team2_5.Models
{
    public class Task
    {
        [Required]
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateOnly? DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }

        [ForeignKey ("Category")] 
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool? Completed { get; set; }
    }
}
