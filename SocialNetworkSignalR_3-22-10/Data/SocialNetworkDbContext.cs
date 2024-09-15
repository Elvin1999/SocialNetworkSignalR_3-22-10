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

    }
}
