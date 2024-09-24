using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetworkSignalR_3_22_10.Entities;

namespace SocialNetworkSignalR_3_22_10.Data
{
    public class SocialNetworkDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options)
            :base(options)
        {
        }

        public DbSet<Friend>? Friends { get; set; }
        public DbSet<FriendRequest>? FriendRequests { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<Chat>? Chats { get; set; }
    }
}
