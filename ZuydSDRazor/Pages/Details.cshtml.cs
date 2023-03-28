using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZuydSDRazor.Pages
{
    public class DetailsModel : PageModel
    {
        private BontenDbContext db;
        public IEnumerable<Video> Videos { get; set; } = null!;
        public IEnumerable<Koppel> Koppels { get; set; } = null!;

        [BindProperty]
        public List<Koppel> test { get; set; } = null!;
        public int OnderwerpId { get; set; }

        public DetailsModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(int Id)
        {
            OnderwerpId = Id;
            // select all vids where the onderwerpId == Koppel.onderwerpId
            Koppels = db.Koppels.Where(e => e.OnderwerpId == OnderwerpId);
            List<Koppel> test = new List<Koppel>(Koppels);

            foreach (Koppel test2 in test)
            {
                Console.WriteLine("First number in the list: " + test);
            }
            //Videos = db.Videos.Where(e=> e.VideoId == test);
        }
    }
}
