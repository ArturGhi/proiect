using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.models;

namespace proiect.Pages.motos
{
    public class IndexModel : PageModel
    {
        private readonly proiect.Data.proiectContext _context;

        public IndexModel(proiect.Data.proiectContext context)
        {
            _context = context;
        }

        public IList<moto> moto { get;set; }

        public async Task OnGetAsync()
        {
            moto = await _context.moto.Include(m => m.Dealer).ToListAsync();
        }
    }
}
