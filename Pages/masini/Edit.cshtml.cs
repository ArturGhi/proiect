using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proiect.Data;
using proiect.models;

namespace proiect.Pages.masini
{
    public class EditModel : PageModel
    {
        private readonly proiect.Data.proiectContext _context;

        public EditModel(proiect.Data.proiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public masina masina { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            masina = await _context.masina.FirstOrDefaultAsync(m => m.id == id);

            if (masina == null)
            {
                return NotFound();
            }
            ViewData["DealerID"] = new SelectList(_context.Set<Dealer>(),"ID","DealerName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(masina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!masinaExists(masina.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool masinaExists(int id)
        {
            return _context.masina.Any(e => e.id == id);
        }
    }
}
