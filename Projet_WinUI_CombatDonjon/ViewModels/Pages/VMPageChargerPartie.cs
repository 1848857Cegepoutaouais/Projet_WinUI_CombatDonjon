using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Projet_WinUI_CombatDonjon.Data.Data;
using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.ViewModels.Pages
{
    public sealed partial class VMPageChargerPartie : ViewModelBase
    {
        private readonly IPartieDataProvider _dataProvider;
        public ObservableCollection<PartieVM> PartieVMs { get; set; } = new ObservableCollection<PartieVM>();

        private PartieVM? _partieSelect;

        public PartieVM? PartieSelect
        {
            get => _partieSelect;
            set
            {
                if (_partieSelect != value)
                {
                    _partieSelect = value;
                    RaisePropertyChanged(nameof(PartieSelect));
                }
            }
        }
        public VMPageChargerPartie(IPartieDataProvider partieDataProvider)
        {
            _dataProvider = partieDataProvider;
        }

        public void ChargerDonnees()
        {
            PartieVMs.Clear();
            foreach (Partie partie in _dataProvider)
        }
    }
}
