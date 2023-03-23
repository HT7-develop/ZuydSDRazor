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
    public class MovesModel : PageModel
    {
        public IEnumerable<Video> Videos { get; set; } = null!;

        private BontenDbContext db;
        public MovesModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            Videos = db.Videos.OrderBy(s => s.Titel).ToList();

        }
    }
}
