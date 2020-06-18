using System.ComponentModel.DataAnnotations;

namespace DattingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }


        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage = "You must have a password between 8 to 14")]    
        public string Password { get; set; }
    }
}