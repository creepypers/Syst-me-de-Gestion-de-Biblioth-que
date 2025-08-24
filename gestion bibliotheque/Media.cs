using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    abstract class Media
    {
        protected string titre;
        protected Employe locataire;
        public Media(string titre) 
        {
            this.titre = titre;
        }
        public bool EstLoue()
        {
            if (locataire == null)
            {
                return false;
            }
            return true;
        }
        public Employe Locataire
        {
            set
            {
                locataire = value;
            }
            get
            {
                return locataire;
            }
        }
        public string Titre
        {
            get { return titre; }   
        }
        public abstract float Retard(int duree);
    }
}
