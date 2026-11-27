using Projet_WinUI_CombatDonjon.Data.Models;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public interface IDonjonDataProvider
    {
        // Méthodes de gestion des parties


        // Méthodes de gestion des joueurs
        List<Joueur> GetJoueurs();
        List<ClasseJoueur> GetClasseJoueurs();
        void AjouterJoueur(Joueur joueur);
        void SupprimerJoueur(int joueurId);
        void ModifierJoueur(int id, string nouvNom, ClasseJoueur nouvClasse);

        // Méthodes de gestion des monstres

        
    }
}
