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
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.DataContext1.DataContext _context;

        public IndexModel(WebApplication1.DataContext1.DataContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task OnGetAsync()
        {
            Etudiant = await _context.etudiants.ToListAsync();
        }
    }
}
