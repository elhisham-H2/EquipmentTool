using System.ComponentModel.DataAnnotations;

namespace EquipmentTool.Models
{
    public class EquipmentRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Email must be in valid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your phone number.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must follow the format xxx-xxx-xxxx (e.g., 905-922-2222).")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select your role.")]
        public UserRole? Role { get; set; }

        [Required(ErrorMessage = "Please select an equipment type.")]
        public EquipmentType? EquipmentType { get; set; }

        [Required(ErrorMessage = "Please enter request details.")]
        public string RequestDetails { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please specify the duration.")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number (greater than zero).")]
        public int? DurationInDays { get; set; }
    }
}
