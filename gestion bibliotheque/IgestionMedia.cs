using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal interface IgestionMedia
    {
        void AjoutLivre(string titre, string auteur, string edition);

        void AjoutVideo(string titre, string realisateur, int anneeSortie);
    }
}
