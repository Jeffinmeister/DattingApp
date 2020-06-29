using System;
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
        
        [Required]
        public string KnownAs { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string City { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}