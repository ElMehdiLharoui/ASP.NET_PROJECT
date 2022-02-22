using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.MODELS
{
   

    public class Etudiant
    {

        public int id { set; get; }
        public int age { set; get; }
        public string nom { set; get; }
        public string prenom { set; get; }
        public Etudiant()
        {

        }
       public Etudiant(int age,string n,string p)
        {
           
            this.age = age;
            this.nom = n;
            prenom = p;

        }


    }
}
