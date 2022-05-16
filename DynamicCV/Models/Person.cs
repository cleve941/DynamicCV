namespace DynamicCV.Models
{
    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
            Role = "";
            Year = "";
            Experience = "";
            Branches = new List<string>();
            Education = new List<string>();
            ProjectHistoryEntries = new List<ProjectHistoryEntry>();
            Languages = new List<Language>();
            Skills = new List<Skill> ();
            TechnicalArea = new TechnicalArea ();
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Year { get; set; }
        public string Experience { get; set; }
        public List<string> Education { get; set; }
        public List<ProjectHistoryEntry> ProjectHistoryEntries { get; set; }
        public List<Language> Languages { get; set; }
        public List<string> Branches { get; set; }
        public List<Skill> Skills { get; set; }
        public TechnicalArea TechnicalArea { get; set; }
    }
}
