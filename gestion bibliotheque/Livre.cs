using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Livre : Media
    {
        private string auteur;
        private string edition;

        public Livre(string titre, string auteur, string edition) : base(titre)
        {
            this.auteur = auteur;
            this.edition = edition;
        }

        public override float Retard(int duree)
        {
            return duree * 10 / 100;
        }
    }
}
