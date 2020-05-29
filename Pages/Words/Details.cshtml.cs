using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VanbaApp.Data;
using VanbaApp.Models;

namespace VanbaApp.Pages.Words
{
    public class DetailsModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public DetailsModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }

        public Word Word { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Word = await _context.Word.FirstOrDefaultAsync(m => m.ID == id);

            if (Word == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
