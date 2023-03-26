using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;

namespace ZuydSDRazor.Pages
{
    public class OnderwerpenModel : PageModel
    {
        public IEnumerable<Onderwerp> Onderwerpen { get; set; } = null!;
        private BontenDbContext db;

        [BindProperty]
        public Onderwerp Onderwerp { get; set; } = null!;

        public OnderwerpenModel(BontenDbContext injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            Onderwerpen = db.Onderwerpen.OrderBy(s => s.Beschrijving).ToList();
        }


        public async Task<IActionResult> OnPost(int id)
        {
            var _onderwerp = await db.Onderwerpen.FindAsync(id);
            if (_onderwerp == null)
            {
                return NotFound();

            }
            db.Onderwerpen.Remove(_onderwerp);
            await db.SaveChangesAsync();
            return RedirectToPage("Courses");
        }

        public async Task<IActionResult> OnPostNew()
        {
            if (Onderwerp.Beschrijving == null)
            {
                ModelState.AddModelError("Onderwerp", "Vul een naam in!");
            }
            if (ModelState.IsValid)
            {
                await db.Onderwerpen.AddAsync(Onderwerp);
                await db.SaveChangesAsync();
                TempData["success"] = "Category created successfully";
                return RedirectToPage("Courses");
            }
            ModelState.AddModelError("Onderwerp", "Vul een naam in!");
            return RedirectToPage("Courses");
        }

    }
}
