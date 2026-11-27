using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Projet_WinUI_CombatDonjon.Data.Data;
using Projet_WinUI_CombatDonjon.Data.Models;
using Projet_WinUI_CombatDonjon.Data.Models.Classes;
using Projet_WinUI_CombatDonjon.ViewModels;
using Projet_WinUI_CombatDonjon.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageChargerPartie : Page
    {
        public VMPageChargerPartie ViewModel { get; set; }
        public PageChargerPartie()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void Button_Suprim_Partie_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.PartieSelect is null) { return; }
            ViewModel.
        }
    }
}
