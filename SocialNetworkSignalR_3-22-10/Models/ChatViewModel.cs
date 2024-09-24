using SocialNetworkSignalR_3_22_10.Entities;

namespace SocialNetworkSignalR_3_22_10.Models
{
    public class ChatViewModel
    {
        public string? CurrentUserId { get; set; }
        public Chat? CurrentChat { get; set; }
        public IEnumerable<Chat>? Chats { get; set; }
    }
}