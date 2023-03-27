using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;

namespace ZuydSDRazor.Pages
{
    public class VideosModel : PageModel
    {
        public IEnumerable<Video> Videos { get; set; } = null!;
        private BontenDbContext db;

        //[BindProperty]
        //public IEnumerable<string> SearchTerm { get; set; } = null!;

        public VideosModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            Videos = db.Videos.OrderBy(s => s.Titel).ToList();
        }

        //public IEnumerable<Video> Search(string SearchTerm)
        //{
        //    //var VideoSearch = await db.Videos.FindAsync(searchString);
            
        //    //db.Videos.Find(VideoSearch);
        //    //return RedirectToPage("Videos");
        //    if (string.IsNullOrWhiteSpace(SearchTerm))
        //    {
        //        Videos = db.Videos.OrderBy(s => s.Titel).ToList();
        //    }
        //    return Videos.Where(e => e.Titel.Contains(SearchTerm));
        //}

        public async Task OnPostAsync()
        {
            var SearchTerm = Request.Form["SearchTerm"];

            Videos = await db.Videos.Where(s => s.Titel.Contains(SearchTerm)).ToListAsync();
        }
    }
}
