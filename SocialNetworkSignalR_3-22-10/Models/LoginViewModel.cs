using System.ComponentModel.DataAnnotations;

namespace SocialNetworkSignalR_3_22_10.Models
{
    public class LoginViewModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
