using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Employe
    {
        public string nom;
        protected string fonction;
        protected int bureau;
        protected string email;

        public Employe(string nom, string fonction, int bureau, string email)
        {
            this.nom = nom;
            this.fonction = fonction;
            if(bureau>=1&&bureau<=99)
                this.bureau = bureau;
            this.email = email;
        }
        public Employe(string nom, string fonction, string email)
        { 
            this.nom = nom;
            this.fonction = fonction;
            this.email=email;
        }
        public int Bureau
        {
            set
            { 
                if (value>=1 && value<=99) 
                {
                    bureau = value;
                }
            }
        }
        public virtual void Afficher()
        {
            Console.WriteLine("\n Le nom de l'employé est : {0}\n son e-mail est : {1} ", nom, email);
        }
        public bool Louer(Media media)
        {
            if (!media.EstLoue())
            {
                media.Locataire = this;
                return true;
            }
            return false;
        }
        public string Nom
        {
            get { return nom; }
        }
    }
}
