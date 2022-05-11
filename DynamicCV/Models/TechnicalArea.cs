namespace DynamicCV.Models
{
    public class TechnicalArea
    {
        public TechnicalArea()
        {
            TechnicalAreaEntries = new List<TechnicalAreaEntry>();
        }
        public List<TechnicalAreaEntry> TechnicalAreaEntries { get; set; } 
    }
}
