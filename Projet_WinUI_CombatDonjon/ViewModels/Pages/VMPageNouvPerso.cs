// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using CombatDonjon.Data.Models;
using Projet_WinUI_CombatDonjon.Data.Data;
using System.Collections.ObjectModel;

namespace Projet_WinUI_CombatDonjon.ViewModels.Pages
{
    public sealed partial class VMPageNouvPerso : ViewModelBase
    {
        private readonly InterfaceDonjonDataProvider _dataProvider;

        public ObservableCollection<PersoVM> PersoVMs { get; } = new ObservableCollection<PersoVM>();

        private PersoVM _nouvPerso;

        public PersoVM NouveauPerso
        {
            get { return _nouvPerso; }
            set
            {
                if (_nouvPerso != value)
                {
                    _nouvPerso = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Titre
        {
            get
            {
                if (NouveauPerso.Id == 0)
                {
                    return "Nouveau Personnage";
                }
                else
                {
                    return $"Modifier le Personnage {NouveauPerso.Nom}";
                }
            }
        }

        public VMPageNouvPerso(InterfaceDonjonDataProvider donjonDataProvider)
        {
            _dataProvider = donjonDataProvider;
            NouveauPerso = CreerNouvPerso();
        }

        private static PersoVM CreerNouvPerso()
        {
            return new PersoVM(new Joueur());
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
    }
}
