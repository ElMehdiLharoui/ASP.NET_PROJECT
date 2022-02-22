using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.MODELS;
using WebApplication1.DataContext1;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        DataContext data;

        public IndexModel(ILogger<IndexModel> logger,DataContext dataContext)
        {
            _logger = logger;
            data = dataContext;
        }

        public void OnGet()
        {
            var etudiant = new Etudiant() { age =55,nom ="jf",prenom ="jfn"} ;
            data.etudiants.Add(etudiant);
            data.SaveChanges();
        }
    }
}
