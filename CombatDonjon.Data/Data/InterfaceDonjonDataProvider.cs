using CombatDonjon.Data.Models;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CombatDonjon.Data.Data
{
    public interface InterfaceDonjonDataProvider
    {
        // Méthodes de gestion des joueurs
        List<Joueur> GetJoueurs();
        void AjouterJoueur(Joueur joueur);
        void SupprimerJoueur(int joueurId);
        void ModifierJoueur(int id, string nouvNom, ClasseJoueur nouvClasse);

        // Méthodes de gestion des monstres

        
    }
}
