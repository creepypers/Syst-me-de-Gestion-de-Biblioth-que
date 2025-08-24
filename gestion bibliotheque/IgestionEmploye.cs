using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal interface IgestionEmploye
    {
        bool AjoutEmploye(string nom, string fonction, int bureau, string email);
        bool AjoutBibliothecaire(string nom, string fonction, string email);
    }
}
