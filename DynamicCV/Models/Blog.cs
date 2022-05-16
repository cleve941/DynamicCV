namespace DynamicCV.Models
{
    public class Blog
    {
        public Blog()
        {
            Title = "";
            Description = "";
            Url = "";
            PictureUrl = "";
            Author = "";
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string PictureUrl { get; set; }
        public string Author { get; set; }
    }
}
