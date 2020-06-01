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
    public class IndexModel : PageModel
    {
        private readonly VanbaApp.Data.VanbaContext _context;

        public IndexModel(VanbaApp.Data.VanbaContext context)
        {
            _context = context;
        }

        public IList<Rule> Rule { get;set; }

        public async Task OnGetAsync()
        {
            Rule = await _context.Rules.ToListAsync();
        }
    }
}
