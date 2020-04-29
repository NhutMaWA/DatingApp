using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="The Username field is required")]
        public string Username { get; set; }
        
        [Required(ErrorMessage="The Password field is required")]
        [StringLength(8, MinimumLength = 4, ErrorMessage="You must specify password between 4 to 8")]
        public string Password { get; set; }
    }
}