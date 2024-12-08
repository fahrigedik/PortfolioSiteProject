using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class SocialLink : BaseEntity
{
    public string PreviewText { get; set; }
    public string SocialMediaLink { get; set; }
    public string? ImageUrl { get; set; }
    public string? SvgData { get; set; }

}

