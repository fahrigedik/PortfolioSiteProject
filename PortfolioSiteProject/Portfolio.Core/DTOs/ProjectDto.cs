namespace Portfolio.Core.DTOs;

public class ProjectDto
{
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public string GithubUrl { get; set; }
    public string PreviewUrl { get; set; }
    public string? SvgData { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsVisible { get; set; }

}

