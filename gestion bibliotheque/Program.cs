using POO2;

//Employe Audrey = new Employe("Audrey", "Professeur", 10, "Audrey@uqar.ca");

//Bibliothecaire David = new Bibliothecaire("David", "Chargé de cours","david@uqar.ca");

//Livre CSharp = new Livre("C#", "Bishop", "2015");

//if (Audrey.Louer(CSharp))
//    Console.WriteLine("\nLocation effectuée");
//else
//    Console.WriteLine("Location non effectuée");

//CSharp.Locataire.Afficher();

//David.Retour(CSharp);

//if (David.Louer(CSharp))
//    Console.WriteLine("\nLocation effectuée");
//else
//    Console.WriteLine("Location non effectuée");

//David.Bureau = 7;

//CSharp.Locataire.Afficher();

Bibliotheque UqarBibliotheque = new Bibliotheque();

UqarBibliotheque.AjoutEmploye("Audrey", "Professeur", 10, "audrey@uqar.ca");

UqarBibliotheque.AjoutBibliothecaire("David", "Bibliothécaire", "david@uqar.ca");

UqarBibliotheque.FindByName("David").Bureau = 7;

UqarBibliotheque.AjoutLivre("C#", "Bishop", "2015");

UqarBibliotheque.AjoutVideo("Apocalyto", "Mel Gibson", 2006);

if (UqarBibliotheque.FindByName("Audrey").Louer(UqarBibliotheque.FindByTitre("C#")))
    Console.WriteLine("Location effctuée");
else
    Console.WriteLine("Location non effctuée");

if (UqarBibliotheque.FindByName("David").Louer(UqarBibliotheque.FindByTitre("Apocalyto")))
    Console.WriteLine("Location effctuée");
else
    Console.WriteLine("Location non effctuée");

UqarBibliotheque.FindByTitre("C#").Locataire.Afficher();
UqarBibliotheque.FindByTitre("Apocalyto").Locataire.Afficher();

Bibliothecaire bibliothecaire = (Bibliothecaire)UqarBibliotheque.FindByName("David");
bibliothecaire.Retour(UqarBibliotheque.FindByTitre("C#"), 10);
bibliothecaire.Retour(UqarBibliotheque.FindByTitre("Apocalyto"), 10);