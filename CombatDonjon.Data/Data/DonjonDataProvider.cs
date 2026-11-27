using Projet_WinUI_CombatDonjon.Data.Models;
using Projet_WinUI_CombatDonjon.Data.Models.Classes;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public class DonjonDataProvider : IDonjonDataProvider
    {
        // Méthodes des parties
        private static List<Partie> _parties;
        private static int _prochainIdPartie = 1;

        private void InitialiserPartie()
        {
            AjouterPartie(new Partie("Partie default", new Donjon(), GetJoueurs()));
        }

        public List<Partie> GetParties()
        {
            if (_parties == null)
            {
                _parties = new List<Partie>();
                InitialiserPartie();
            }
            return _parties;
        }

        public void AjouterPartie(Partie partie)
        {
            ArgumentNullException.ThrowIfNull(partie);

            partie.PartieId = _prochainIdPartie++;
            _parties.Add(partie);
        }

        // Méthodes des joueurs
        private static List<Joueur>? _joueurs;
        private static List<ClasseJoueur>? _classeJoueurs;
        private static int _prochainIdJoueur = 1;
        private void InitialiserJoueurs()
        {
            AjouterJoueur(new Joueur("Joueur par défault Barbare", new Barbare()));
            AjouterJoueur(new Joueur("Joueur par défault Chasseur", new Chasseur()));
            AjouterJoueur(new Joueur("Joueur par défault Mage", new Mage()));
        }

        private void InitialiserClassesJoueurs()
        {
            _classeJoueurs.Add(new Barbare());
            _classeJoueurs.Add(new Chasseur());
            _classeJoueurs.Add(new Mage());
        }

        public List<Joueur> GetJoueurs()
        {
            if (_joueurs == null)
            {
                _joueurs = new List<Joueur>();
                InitialiserJoueurs();
            }

            return _joueurs;
        }

        public List<ClasseJoueur> GetClasseJoueurs()
        {
            if (_classeJoueurs == null)
            {
                _classeJoueurs = new List<ClasseJoueur>();
                InitialiserClassesJoueurs();
            }

            return _classeJoueurs;
        }

        public void AjouterJoueur(Joueur joueur)
        {
            ArgumentNullException.ThrowIfNull(joueur);

            joueur.Id = _prochainIdJoueur++;
            _joueurs.Add(joueur);
        }

        public void SupprimerJoueur(int joueurId)
        {
            Joueur? joueur = _joueurs.FirstOrDefault(j =>  j.Id == joueurId);
            if (joueur != null)
            {
                _joueurs.Remove(joueur);
            }
        }

        public void ModifierJoueur(int id, string nouvNom, ClasseJoueur nouvClasse)
        {
            Joueur? jExiste = _joueurs.FirstOrDefault(j => j.Id == id);
            if (jExiste != null)
            {
                // Si le nom est différent du nouveau nom, on le change
                if (jExiste.Nom != nouvNom)
                {
                    jExiste.Nom = nouvNom;
                }

                // Si la classe du personnage est différent de la nouvelle classe, on la change
                // TODO Faire en sorte que ça change pas la classeJoueur si on ne la change pas
                if (jExiste.Classe.GetType() != nouvClasse.GetType())
                {
                    jExiste.Classe = nouvClasse;
                }
            }
        }

        
    }
}
