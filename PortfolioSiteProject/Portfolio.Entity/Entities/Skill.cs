
using Portfolio.Core.Base;

namespace Portfolio.Entity.Entities
{
    public class Skill : BaseEntity
    {
        public string SkillName { get; set; }
        public byte[] ImageData { get; set; }  // Resim verisi (binary format)
        public string ImageMimeType { get; set; }  // Resmin türü (image/png, image/jpeg gibi)
        public string SvgData { get; set; }
    }
}
