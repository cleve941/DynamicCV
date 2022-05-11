namespace DynamicCV.Models
{
    public class TechnicalAreaEntry
    {
        public TechnicalAreaEntry(string name)
        {
            Name = name;
            Area = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Area { get; set; }
    }
}
