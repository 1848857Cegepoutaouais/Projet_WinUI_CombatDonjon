using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Projet_WinUI_CombatDonjon.ViewModels.Pages;
using Projet_WinUI_CombatDonjon.ViewModels;
using Projet_WinUI_CombatDonjon.Data.Data;
using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using Projet_WinUI_CombatDonjon.Data.Models.Classes;

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

            ViewModel.ChargerDonnees();
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

            Frame.Navigate(typeof(PageNouvPerso), ViewModel.PersoSelect);
        }

        private void Button_Supprim_Perso_Click(Object sender, RoutedEventArgs e)
        {
            if (ViewModel.PersoSelect is null)
            {
                return;
            }

            ViewModel.SupprimPerso();
        }

        /// <summary>
        /// Méthode pour créer un personnage de test rapide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_nv_PersoD_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            TypeClasse typeClasseDefault = (TypeClasse)rnd.Next(3);
            ClasseJoueur classeDefault = ClasseJoueur.ConvertEnumTypeClasseToClasse(typeClasseDefault);
            PersoVM dPerso = new PersoVM(new Joueur($"Test Perso", classeDefault));
            Frame.Navigate(typeof(PageNouvPartie), dPerso);
        }

        private void Button_Nv_Partie_Fin_Click(object sender, RoutedEventArgs e)
        {
            // Sauvegarder la partie dans la BD
            // TODO

            // Naviguer vers la page combat
            Frame.Navigate(typeof(PageCombat));
        }
    }
}
