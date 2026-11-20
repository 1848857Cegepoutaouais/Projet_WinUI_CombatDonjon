using CombatDonjon.Data.Data;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Projet_WinUI_CombatDonjon.ViewModels;
using Projet_WinUI_CombatDonjon.ViewModels.Pages;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageNouvPerso : Page
    {
        public VMPageNouvPerso ViewModel { get; }
        public PageNouvPerso()
        {
            ViewModel = new VMPageNouvPerso(new DonjonDataProvider());
            InitializeComponent();
            
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

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        private void Button_Creer_Perso_Click(object sender, EventArgs e)
        {
            if (ViewModel.NouveauPerso.EstValide)
            {
                Frame.Navigate(typeof(PageNouvPartie), ViewModel.NouveauPerso);
            }
        }

        private void Button_Annuler_Perso_Click(object sender, EventArgs e)
        {
            Frame.Navigate(typeof(PageNouvPartie));
        }
    }
}
