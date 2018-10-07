using System.ComponentModel.DataAnnotations;

namespace Models.DataAccess.DataTransion.Dto
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [StringLength(60)]
        public string CusID { get; set; }

        [Required]
        [StringLength(20)]
        public string Passwd { get; set; }

        public int GrantID { get; set; }
    }
}