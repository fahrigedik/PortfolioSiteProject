using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class Project : BaseEntity
{
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public string GithubUrl { get; set; }
    public string PreviewUrl { get; set; }
    public string? ImageUrl { get; set; }
    public string? SvgData { get; set; }
}

