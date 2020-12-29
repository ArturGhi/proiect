using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.models;

namespace proiect.Pages.masini
{
    public class IndexModel : PageModel
    {
        private readonly proiect.Data.proiectContext _context;

        public IndexModel(proiect.Data.proiectContext context)
        {
            _context = context;
        }

        public IList<masina> masina { get;set; }

        public async Task OnGetAsync()
        {
            masina = await _context.masina.Include(b=>b.Dealer).ToListAsync();
        }
    }
}
