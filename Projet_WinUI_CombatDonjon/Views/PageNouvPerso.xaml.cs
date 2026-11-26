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
    public sealed partial class PageNouvPerso : Page
    {
        public VMPageNouvPerso ViewModel { get; private set; }

        // Voir si c'est possible de choisir la classe Joueur directement plutot que de passé par un Enum

        public IReadOnlyList<TypeClasse> ClasseOptions { get; } = Enum.GetValues(typeof(TypeClasse)).Cast<TypeClasse>().ToList();

        // ChoixClasse sert pour stocké le choix de classe avant de créer le personnage
        public TypeClasse ChoixClasse { get; set; }

        public PageNouvPerso()
        {
            InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is PersoVM persoAModifier)
            {
                PersoVM copie = new PersoVM(new Joueur { Id = persoAModifier.Id, Nom = persoAModifier.Nom, Classe = persoAModifier.Classe });

                ViewModel = new VMPageNouvPerso(copie);

                ChoixClasse = ClasseJoueur.ConvertClasseToEnumTypeClasse(copie.Classe);
            }
            else
            {
                ViewModel = new VMPageNouvPerso();
            }

        }

        private void Button_Creer_Perso_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.NouveauPerso.EstValide)
            {
                ViewModel.NouveauPerso.Classe = ClasseJoueur.ConvertEnumTypeClasseToClasse(ChoixClasse);
                Frame.Navigate(typeof(PageNouvPartie), ViewModel.NouveauPerso);
            }
        }

        private void Button_Annuler_Perso_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PageNouvPartie));
        }
    }
}
