namespace Portfolio.Core.DTOs;

public class ProjectDto
{
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public string GithubUrl { get; set; }
    public string PreviewUrl { get; set; }
    public byte[]? ImageData { get; set; }  // Resim verisi (binary format)
    public string? ImageMimeType { get; set; }  // Resmin türü (image/png, image/jpeg gibi)
    public string? SvgData { get; set; }
}

