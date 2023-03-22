namespace ZuydSDRazor.Models
{
    public class Video
    {
        public string? VideoId { get; set; }
        public string? Link { get; set; }
        public string? Titel { get; set; }
        public ICollection<Onderwerp>? Onderwerpen { get; set; }
    }
}



