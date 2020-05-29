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
    public class IndexModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public IndexModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }
        public int TodoCount{get;set;}
        public IList<Word> Word { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var words = from w in _context.Word where !w.Text.Equals(null)
                 select w;
    if (!string.IsNullOrEmpty(SearchString))
    {
        words = words.Where(s => s.Text.ToLower().Contains(SearchString.ToLower())||
                    s.MeaningAsVerb.ToLower().Contains(SearchString.ToLower())||
                    s.MeaningAsNoun.ToLower().Contains(SearchString.ToLower())||
                    s.MeaningAsAdjective.ToLower().Contains(SearchString.ToLower()));
    }
            Word = await words.OrderBy(x=>x.Text).ToListAsync();
            var todoWords = from w in _context.Word select w;
            todoWords = todoWords.Where(s => s.Text.Equals(null));
            var list = await todoWords.ToListAsync();
            TodoCount = list.Count();
        }
    }
}
