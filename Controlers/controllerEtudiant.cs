using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DataContext1;
using WebApplication1.MODELS;
using System.Net.Mime;
using Microsoft.Extensions.Logging;
using Serilog;

namespace WebApplication1.Controlers
{
    [Route("api/Etudiant")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
   
    public class controllerEtudiant : ControllerBase
    {
        private readonly ILogger<controllerEtudiant> _logger;
        DataContext d1;
        
        public controllerEtudiant(DataContext d, ILogger<controllerEtudiant> logger)
        {
           
            _logger = logger;
            d1 = d;
        }
        [HttpGet]
        public List<Etudiant> GetEtudiants()
        {
            _logger.LogInformation("les information");
            return d1.etudiants.ToList();
        }
        [HttpPost]
        public Etudiant GetEtudiant(int? id)
        {
            if(id==null)
            {
                return null;
            }

            return d1.etudiants.FirstOrDefault(e => e.id == id);
        }

    }
}
