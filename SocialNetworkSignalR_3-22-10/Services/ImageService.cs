
namespace SocialNetworkSignalR_3_22_10.Services
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _webHost;

        public ImageService(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public async Task<string> SaveFile(IFormFile file)
        {
            var saveImage = Path.Combine(_webHost.WebRootPath, "images", file.FileName);
            using (var img = new FileStream(saveImage, FileMode.OpenOrCreate))
            {
                await file.CopyToAsync(img);
            }
            return file.FileName.ToString();
        }
    }
}
