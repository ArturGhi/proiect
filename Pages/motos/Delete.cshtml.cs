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
    public class DeleteModel : PageModel
    {
        private readonly proiect.Data.proiectContext _context;

        public DeleteModel(proiect.Data.proiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public moto moto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            moto = await _context.moto
                .Include(m => m.Dealer).FirstOrDefaultAsync(m => m.id == id);

            if (moto == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            moto = await _context.moto.FindAsync(id);

            if (moto != null)
            {
                _context.moto.Remove(moto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
