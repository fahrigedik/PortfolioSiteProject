
using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class HeroSection : BaseEntity
{
    public string Title1 { get; set; }
    public string Title2 { get; set; }
    public string Title3 { get; set; }
    public string InformationDescription { get; set; }
    public byte[]? ImageData { get; set; }  // Resim verisi (binary format)
    public string? ImageMimeType { get; set; }  // Resmin türü (image/png, image/jpeg gibi)
    public string? SvgData { get; set; }
}

