using Microsoft.AspNetCore.Identity;

namespace SocialNetworkSignalR_3_22_10.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        public string? Image { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DisConnectTime { get; set; } = DateTime.Now;
        public string? ConnectTime { get; set; } = "";
    }
}
