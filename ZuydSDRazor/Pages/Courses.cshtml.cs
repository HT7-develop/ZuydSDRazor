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
    public class CoursesModel : PageModel
    {
        public IEnumerable<Onderwerp> Onderwerpen { get; set; } = null!;

        private BontenDbContext db;
        public CoursesModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            Onderwerpen = db.Onderwerpen.OrderBy(s => s.Beschrijving).ToList();

        }
    }
}
