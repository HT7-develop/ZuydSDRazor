using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZuydSDRazor.Models
{
    public class Onderwerp
    {
        public int OnderwerpId { get; set; }
        [Required]
        public string? Beschrijving { get; set; }
        public ICollection<Video>? Videos { get; set; }
    }
}
