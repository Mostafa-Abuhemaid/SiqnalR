using System.ComponentModel.DataAnnotations;

namespace SiqnalRProject.Model
{
    public class Notification
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
