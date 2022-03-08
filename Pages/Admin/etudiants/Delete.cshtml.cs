using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataContext1;
using WebApplication1.MODELS;

namespace WebApplication1.Pages.etudiants
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.DataContext1.DataContext _context;

        public DeleteModel(WebApplication1.DataContext1.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.etudiants.FirstOrDefaultAsync(m => m.id == id);

            if (Etudiant == null)
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

            Etudiant = await _context.etudiants.FindAsync(id);

            if (Etudiant != null)
            {
                _context.etudiants.Remove(Etudiant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
