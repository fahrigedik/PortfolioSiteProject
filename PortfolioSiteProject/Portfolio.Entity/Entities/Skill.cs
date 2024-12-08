
using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities
{
    public class Skill : BaseEntity
    {
        public string SkillName { get; set; }
        public string? ImageUrl { get; set; }
        public string? SvgData { get; set; }
    }
}
