using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VanbaApp.Data;
using VanbaApp.Models;

namespace VanbaApp.Pages.Rules
{
    public class DetailsModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public DetailsModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }

        public Rule Rule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rule = await _context.Rules.FirstOrDefaultAsync(m => m.ID == id);

            if (Rule == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
