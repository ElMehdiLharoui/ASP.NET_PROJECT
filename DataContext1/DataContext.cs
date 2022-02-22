
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.MODELS;
namespace WebApplication1.DataContext1
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> op) : base(op)
        {

        }
        public DbSet<Etudiant> etudiants { get; set; }
    }
}
