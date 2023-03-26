using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;

namespace ZuydSDRazor.Pages
{
    public class DetailsModel : PageModel
    {
        private BontenDbContext db;
        public IEnumerable<Video> Videos { get; set; } = null!;
        public string VideoSearch { get; set; }

        public DetailsModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(int Id)
        {
            Videos = db.Videos.ToList();
            //VideoSearch = Videos;
        }
    }
}
