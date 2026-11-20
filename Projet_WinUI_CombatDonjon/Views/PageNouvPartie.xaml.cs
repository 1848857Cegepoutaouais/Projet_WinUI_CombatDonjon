using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Projet_WinUI_CombatDonjon.ViewModels.Pages;
using Projet_WinUI_CombatDonjon.ViewModels;
using CombatDonjon.Data.Data;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageNouvPartie : Page
    {
        public VMPageNouvPartie ViewModel { get; }
        public PageNouvPartie()
        {
            ViewModel = new VMPageNouvPartie(new DonjonDataProvider());
            InitializeComponent();
            ViewModel.ChargerDonnees();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is PersoVM persoVM)
            {
                if (persoVM.Id == 0) // C'est un nouveau perso, donc on l'ajoute
                {
                    ViewModel.AjouterPerso(persoVM);
                }
                else
                {
                    ViewModel.ModifierPerso(persoVM);
                }
            }
        }

        private void Button_Nv_Perso_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PageNouvPerso));
        }

        private void Button_Modif_Perso_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.PersoSelect is null)
            {
                return;
            }

            Frame.Navigate(typeof(VMPageNouvPerso), ViewModel.PersoSelect);
        }

        private void Button_nv_PersoD_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PageNouvPerso));
        }

        private void Button_Nv_Partie_Fin_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
            Frame.Navigate(typeof(PageNouvPerso));
        }
    }
}
