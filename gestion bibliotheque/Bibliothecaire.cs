using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Bibliothecaire : Employe
    {
        public Bibliothecaire(string nom, string fonction, string email) :
            base(nom,fonction, email)
        { 

        }
        public void Retour(Media media, int duree)
        {
            if(duree > 0)
                Console.WriteLine("La pénalité de retard est {0} $ ", media.Retard(duree));
           media.Locataire = null;
        }
        public override void Afficher()
        {
            Console.WriteLine("\n Le nom de l'employé est : {0}\n son e-mail est : {1} \n Et son bureau est : {2}", nom, email, bureau);
        }
    }
}
