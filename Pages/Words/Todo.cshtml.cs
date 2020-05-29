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
    public class TodoModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public TodoModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }

        public IList<Word> Word { get; set; }

        public async Task OnGetAsync()
        {
            var words = from w in _context.Word
                        select w;

            words = words.Where(s => s.Text.Equals(null));

            Word = await words.ToListAsync();
        }
    }
}
