using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class SocialLink : BaseEntity
{
    public string PreviewText { get; set; }
    public string SocialMediaLink { get; set; }
    public byte[]? ImageData { get; set; }  // Resim verisi (binary format)
    public string? ImageMimeType { get; set; }  // Resmin türü (image/png, image/jpeg gibi)
    public string? SvgData { get; set; }
}

