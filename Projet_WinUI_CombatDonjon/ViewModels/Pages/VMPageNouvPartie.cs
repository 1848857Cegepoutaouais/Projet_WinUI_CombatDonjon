using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Projet_WinUI_CombatDonjon.Data;
using Projet_WinUI_CombatDonjon.Models;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.ViewModels.Pages
{
    public class VMPageNouvPartie : ViewModelBase
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

        public VMPageNouvPartie(InterfaceDonjonDataProvider donjonDataProvider)
        {
            _dataProvider = donjonDataProvider;
            NouveauPerso = CreerNouvPerso();
        }

        private static PersoVM CreerNouvPerso()
        {
            return new PersoVM(new Joueur());
        }

        public void ChargerDonnees()
        {
            PersoVMs.Clear();
            foreach(Joueur joueur in _dataProvider.GetJoueurs())
            {
                PersoVMs.Add(new PersoVM(joueur));
            } 
        }
    }
}
