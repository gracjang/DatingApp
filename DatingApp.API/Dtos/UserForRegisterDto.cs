using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 8, ErrorMessage = " You must specify password between 8-14 characters")]
        public string Password { get; set; }    
    }
}