using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Bibliotheque : IgestionEmploye,IgestionMedia
    {
        private List<Employe> employes;
        private List<Media> medias;

        public Bibliotheque()
        {
            employes=new List<Employe>();
            medias=new List<Media>();
        }
        public Employe FindByName(string nom)
        {
            foreach(Employe employe in employes)
            if(employe.Nom.Equals(nom))
                return employe;
            return null;
        }
        public Media FindByTitre(string titre)
        {
            foreach (Media media in medias)
                if (media.Titre.Equals(titre))
                    return media;
            return null;
        }

        public bool AjoutEmploye(string nom, string fonction, int bureau, string email)
        {
            if (FindByName(nom) == null)
            {
                employes.Add(new Employe(nom, fonction, bureau, email));
                return true;
            }
                return false;
        }
        public bool AjoutBibliothecaire(string nom, string fonction, string email)
        {
            if(FindByName(nom) == null)
            {
                employes.Add(new Bibliothecaire(nom, fonction, email));
                return true;
            }
            return false;
        }
        public void LesEmployes()
        { 
            foreach (Employe employe in employes)
                employe.Afficher();
        }
        public void AjoutLivre(string titre, string auteur, string edition)
        {
            medias.Add(new Livre(titre, auteur, edition));
        }
        public void AjoutVideo(string titre, string realisateur, int anneeSortie)
        {
            medias.Add(new Video(titre, realisateur ,anneeSortie));
        }
    }
}
