namespace SocialNetworkSignalR_3_22_10.Models
{
    public class RegisterViewModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public IFormFile? File { get; set; }
        public string? ImageUrl { get; set; }
    }
}
