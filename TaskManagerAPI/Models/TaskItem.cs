using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, ErrorMessage = "The Name field cannot exceed 100 characters.")]
        public string? Name { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [DateInTheFuture(ErrorMessage = "The DueDate field should be on a future date.")]
        public DateTime? DueDate { get; set; }
        [StringLength(250, ErrorMessage = "The Description field cannot exceed 250 characters.")]
        public string? Description { get; set; }
        [Required]
        public Priority Priority { get; set; }
    }

    // Custom validation attribute example
    public class DateInTheFutureAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }

            if (value is DateTime dateTime)
            {
                return dateTime > DateTime.UtcNow;
            }

            return false;
        }
    }
}