using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;

namespace ZuydSDRazor.Pages
{
    public class VideosModel : PageModel
    {
        public IEnumerable<Video> Videos { get; set; } = null!;
        private BontenDbContext db;
        [BindProperty]
        public string VideoSearch { get; set; }

        public VideosModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            Videos = db.Videos.OrderBy(s => s.Titel).ToList();
        }
        public async Task<IActionResult> OnGetSearch(string searchString)
        {
            var VideoSearch = await db.Videos.FindAsync(searchString);
            
            db.Videos.Find(VideoSearch);
            return RedirectToPage("Videos");
        }
    }
}
