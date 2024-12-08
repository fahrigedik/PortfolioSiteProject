
using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class HeroSection : BaseEntity
{
    public string Title1 { get; set; }
    public string Title2 { get; set; }
    public string Title3 { get; set; }
    public string InformationDescription { get; set; }
    public string? ImageUrl { get; set; }
    public string? SvgData { get; set; }
}

