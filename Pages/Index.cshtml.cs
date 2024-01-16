using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PharmaPlus.Data;

namespace PharmaPlus.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PharmaPlus.Data.AppDbContext _context;

        public IndexModel(PharmaPlus.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.med != null)
            {
                Medicine = await _context.med.ToListAsync();
            }
        }
    }
}
