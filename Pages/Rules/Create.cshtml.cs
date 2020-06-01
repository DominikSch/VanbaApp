using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VanbaApp.Data;
using VanbaApp.Models;

namespace VanbaApp.Pages.Rules
{
    public class CreateModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public CreateModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rule Rule { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rules.Add(Rule);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
