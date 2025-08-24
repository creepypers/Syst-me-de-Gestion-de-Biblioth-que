using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Video : Media
    {
        private string realisateur;
        private int anneeSortie;

        public Video(string titre, string realisateur, int anneeSortie) : base(titre)
        {
            this.realisateur = realisateur;
            this.anneeSortie = anneeSortie;
        }
        public override float Retard(int duree)
        {
            if ((DateTime.Now.Year - anneeSortie) != 0)
                return duree * 1 / (float)(DateTime.Now.Year - anneeSortie);
            return duree * 1;
        }
    }
}
