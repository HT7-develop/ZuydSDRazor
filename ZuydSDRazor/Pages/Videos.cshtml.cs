using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;
using System.ComponentModel.DataAnnotations;


namespace ZuydSDRazor.Pages
{
    public class VideosModel : PageModel
    {
        public IEnumerable<Video> Videos { get; set; } = null!;
        private BontenDbContext db;

        [Required(ErrorMessage = "Veld mag niet leeg zijn.")]
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public VideosModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(string sortOrder)
        {
            switch (sortOrder)
            {
                case "Title_Desc":
                    Videos = db.Videos.OrderByDescending(v => v.Titel).ToList();
                    break;
                case "Link_Asc":
                    Videos = db.Videos.OrderBy(v => v.Link).ToList();
                    break;
                case "Link_Desc":
                    Videos = db.Videos.OrderByDescending(v => v.Link).ToList();
                    break;
                default:
                    Videos = db.Videos.OrderBy(v => v.Titel).ToList();
                    break;
            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                if (Videos != null)
                {
                    Videos = Videos.Where(v =>v.Titel.ToLower().Contains(SearchString.ToLower())).ToList();
                }
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



        }

        public async Task OnPostAsync()
        {
            var SearchTerm = Request.Form["SearchTerm"];

            Videos = await db.Videos.Where(s => s.Titel.Contains(SearchString)).ToListAsync();
        }
    }
}
