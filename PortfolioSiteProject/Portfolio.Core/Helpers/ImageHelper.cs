using Microsoft.AspNetCore.Http;

namespace Portfolio.Core.Helpers
{
    public static class ImageHelper
    {
        public static byte[] ConvertToByteArray(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
