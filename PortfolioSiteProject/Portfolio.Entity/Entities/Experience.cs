
using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities;
public class Experience : BaseEntity
{
    public string JobTitle { get; set; }
    public string JobDescription { get; set; }
    public string Company { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
