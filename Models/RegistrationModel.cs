// Models/RegistrationModel.cs
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required]
        public required string Name { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Range(1, 10, ErrorMessage = "Please select between 1 and 10 tickets.")]
        public int Tickets { get; set; }
    }
}