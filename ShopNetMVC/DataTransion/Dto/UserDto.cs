using System.ComponentModel.DataAnnotations;

namespace ShopNetMVC.DataTransion.Dto
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}