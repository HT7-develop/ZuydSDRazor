namespace ZuydSDRazor.Models
{
    public class Onderwerp
    {
        public int OnderwerpId { get; set; }    
        public string? Beschrijving { get; set; }
        public ICollection<Video>? Videos { get; set; }
    }
}
