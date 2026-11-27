using System.Collections.ObjectModel;
using Projet_WinUI_CombatDonjon.Data.Data;
using Projet_WinUI_CombatDonjon.Data.Models;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.ViewModels.Pages
{
    public class VMPageNouvPartie : ViewModelBase
    {
        private readonly IDonjonDataProvider _dataProvider;
        public ObservableCollection<PersoVM> PersoVMs { get; } = new ObservableCollection<PersoVM>();

        private PartieVM _nouvPartie;

        public PartieVM NouvellePartie
        {
            get { return _nouvPartie; }
            set
            {
                if (_nouvPartie != value)
                {
                    _nouvPartie = value;
                    RaisePropertyChanged();
                }
            }
        }

        private PersoVM? _persoSelect;

        public PersoVM? PersoSelect
        {
            get { return _persoSelect; }
            set
            {
                if (_persoSelect != value)
                {
                    _persoSelect = value;
                    RaisePropertyChanged();
                }
            }
        }

        public VMPageNouvPartie(PartieVM partieVM)
        {
            NouvellePartie = partieVM;
        }

        public VMPageNouvPartie(IDonjonDataProvider donjonDataProvider)
        {
            _dataProvider = donjonDataProvider;
            //NouveauPerso = CreerNouvPerso();
        }

        /*private static PersoVM CreerNouvPerso()
        {
            return new PersoVM(new Joueur());
        }*/

        public void ChargerDonnees()
        {
            PersoVMs.Clear();
            foreach(Joueur joueur in _dataProvider.GetJoueurs())
            {
                PersoVMs.Add(new PersoVM(joueur));
            } 
        }

        public void AjouterPerso(PersoVM persoVM)
        {
            _dataProvider.AjouterJoueur(new Joueur(persoVM.Nom, persoVM.Classe));
        }

        public void ModifierPerso(PersoVM persoVM)
        {
            if (persoVM == null)
            {
                return;
            }
            _dataProvider.ModifierJoueur(persoVM.Id, persoVM.Nom, persoVM.Classe);
        }

        public void SupprimPerso()
        {
            if (PersoSelect == null)
            {
                return;
            }

            _dataProvider.SupprimerJoueur(PersoSelect.Id);
            PersoVMs.Remove(PersoSelect);
            PersoSelect = null;
        }
    }
}
