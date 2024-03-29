using System.ComponentModel.DataAnnotations;

namespace LocalPrinting.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Yu must specify password between 4 and 8 charcters")]
        public string Password { get; set; }
    }
}