using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {  
        [Required]  //Makes it so that the user can't post empty username/password, is possible because AuthController implements ApiController
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage="You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}