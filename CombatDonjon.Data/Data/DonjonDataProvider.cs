using Projet_WinUI_CombatDonjon.Data.Models;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public class DonjonDataProvider : InterfaceDonjonDataProvider
    {
        private static List<Joueur>? _joueurs;
        private static int _prochainIdJoueur = 1;
        private void InitialiserJoueurs()
        {
            //TODO
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
                if (jExiste.Classe != nouvClasse)
                {
                    jExiste.Classe = nouvClasse;
                }
            }
        }

        
    }
}
