# 📚 Système de Gestion de Bibliothèque

Un système de gestion de bibliothèque développé en C# qui permet de gérer les employés, les médias (livres et vidéos) et les opérations de location.

## 🎯 Fonctionnalités

### 👥 Gestion des Employés
- **Employés** : Création et gestion des employés avec nom, fonction, bureau et email
- **Bibliothécaires** : Gestion spécialisée des bibliothécaires avec fonctionnalités de retour
- Système de recherche par nom
- Attribution de bureaux (1-99)

### 📖 Gestion des Médias
- **Livres** : Gestion des livres avec titre, auteur et édition
- **Vidéos** : Gestion des vidéos avec titre, réalisateur et année de sortie
- Système de recherche par titre
- Gestion des locations et retours

### 🔄 Système de Location
- Location de médias par les employés
- Vérification de disponibilité
- Calcul automatique des pénalités de retard
- Gestion des retours par les bibliothécaires

## 🏗️ Architecture du Projet

### Classes Principales

#### `Bibliotheque` (Classe principale)
- Implémente `IgestionEmploye` et `IgestionMedia`
- Gère les listes d'employés et de médias
- Méthodes de recherche et d'ajout

#### `Media` (Classe abstraite)
- Classe de base pour tous les types de médias
- Gestion des locations et locataires
- Méthode abstraite `Retard()` pour calculer les pénalités

#### `Employe`
- Gestion des informations de base des employés
- Fonctionnalité de location de médias
- Validation des numéros de bureau

#### `Bibliothecaire` (Hérite d'`Employe`)
- Fonctionnalités spécialisées pour les bibliothécaires
- Gestion des retours avec calcul de pénalités
- Affichage des informations incluant le bureau

#### `Livre` (Hérite de `Media`)
- Gestion des livres avec auteur et édition
- Calcul des pénalités : 10% par jour de retard

#### `Video` (Hérite de `Media`)
- Gestion des vidéos avec réalisateur et année de sortie
- Calcul des pénalités basé sur l'ancienneté du film

### Interfaces

#### `IgestionEmploye`
- `AjoutEmploye()` : Ajout d'un nouvel employé
- `AjoutBibliothecaire()` : Ajout d'un nouveau bibliothécaire

#### `IgestionMedia`
- `AjoutLivre()` : Ajout d'un nouveau livre
- `AjoutVideo()` : Ajout d'une nouvelle vidéo

## 🚀 Utilisation

### Exemple d'utilisation dans `Program.cs`

```csharp
// Création d'une bibliothèque
Bibliotheque UqarBibliotheque = new Bibliotheque();

// Ajout d'employés
UqarBibliotheque.AjoutEmploye("Audrey", "Professeur", 10, "audrey@uqar.ca");
UqarBibliotheque.AjoutBibliothecaire("David", "Bibliothécaire", "david@uqar.ca");

// Ajout de médias
UqarBibliotheque.AjoutLivre("C#", "Bishop", "2015");
UqarBibliotheque.AjoutVideo("Apocalyto", "Mel Gibson", 2006);

// Location de médias
if (UqarBibliotheque.FindByName("Audrey").Louer(UqarBibliotheque.FindByTitre("C#")))
    Console.WriteLine("Location effectuée");

// Retour de médias avec calcul de pénalités
Bibliothecaire bibliothecaire = (Bibliothecaire)UqarBibliotheque.FindByName("David");
bibliothecaire.Retour(UqarBibliotheque.FindByTitre("C#"), 10);
```

## 📋 Prérequis

- .NET Framework ou .NET Core
- Visual Studio ou autre IDE compatible C#
- Windows (testé sur Windows 10)

## 🔧 Installation et Compilation

1. Clonez ou téléchargez le projet
2. Ouvrez le fichier `POO2.sln` dans Visual Studio
3. Restaurez les packages NuGet si nécessaire
4. Compilez le projet (Ctrl+Shift+B)
5. Exécutez le programme (F5)

## 📁 Structure des Fichiers

```
gestion bibliotheque/
├── POO2.sln                 # Solution Visual Studio
├── Program.cs               # Point d'entrée principal
├── Bibliotheque.cs          # Classe principale de gestion
├── Media.cs                 # Classe abstraite des médias
├── Livre.cs                 # Classe des livres
├── Video.cs                 # Classe des vidéos
├── Employe.cs               # Classe des employés
├── Bibliothecaire.cs        # Classe des bibliothécaires
├── IgestionEmploye.cs       # Interface de gestion des employés
└── IgestionMedia.cs         # Interface de gestion des médias
```

## 🧪 Fonctionnalités Testées

- ✅ Ajout d'employés et bibliothécaires
- ✅ Ajout de livres et vidéos
- ✅ Recherche par nom et par titre
- ✅ Location de médias
- ✅ Retour de médias avec calcul de pénalités
- ✅ Gestion des bureaux
- ✅ Validation des données

## 🔮 Améliorations Possibles

- Interface utilisateur graphique (WPF/WinForms)
- Base de données pour la persistance des données
- Système d'authentification
- Gestion des catégories de médias
- Historique des locations
- Rapports et statistiques
- Gestion des réservations

## 👨‍💻 Développement

Ce projet a été développé dans le cadre d'un cours de Programmation Orientée Objet (POO) à l'UQAR.

## 📄 Licence

Projet éducatif - Tous droits réservés.

---

*Développé avec ❤️ en C#*
