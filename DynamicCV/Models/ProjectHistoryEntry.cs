using System.Collections.Generic;

namespace DynamicCV.Models
{
    public class ProjectHistoryEntry
    {
        public string? Subject { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string? Role { get; set; }
        public string? Customer { get; set; }
        public List<string>? UsedTechnologies { get; set; }
        public string? DescriptionTitle { get; set; }
        public List<string>? DescriptionPoints { get; set; }
    }
}
