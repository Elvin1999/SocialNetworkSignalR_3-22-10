namespace SocialNetworkSignalR_3_22_10.Services
{
    public interface IImageService
    {
        Task<string> SaveFile(IFormFile file);
    }
}
