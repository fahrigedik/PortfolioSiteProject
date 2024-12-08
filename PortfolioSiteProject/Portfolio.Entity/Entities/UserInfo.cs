using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;

public class UserInfo : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public string UserDescription { get; set; }
    public string? ImageUrl { get; set; }
    public string? SvgData { get; set; }
}

