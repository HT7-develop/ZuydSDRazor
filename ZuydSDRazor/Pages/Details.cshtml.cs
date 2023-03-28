using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZuydSDRazor.Pages
{
    public class DetailsModel : PageModel
    {
        public IEnumerable<Onderwerp> onderwerpen { get; set; } = null!;
        public Onderwerp? Onderwerp { get; set; }
        public Video? Video { get; set; }
        private BontenDbContext db;

        public DetailsModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Onderwerp = await db.Onderwerpen.Include(s => s.Videos).SingleOrDefaultAsync(v => v.OnderwerpId == id);
            Video = await db.Videos.Include(v => v.Onderwerpen).SingleOrDefaultAsync(o => o.VideoId == id);

            if (Onderwerp == null || Video == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
