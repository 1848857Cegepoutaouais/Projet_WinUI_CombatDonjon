using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Projet_WinUI_CombatDonjon.ViewModels.Pages;
using Projet_WinUI_CombatDonjon.Data;
using Projet_WinUI_CombatDonjon.Models;
using Projet_WinUI_CombatDonjon.ViewModels;
using Projet_WinUI_CombatDonjon.Views;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageTitre : Page
    {
        public VMPageTitre ViewModel { get; }
        public PageTitre()
        {
            InitializeComponent();

            ViewModel = new VMPageTitre();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        // Fonction pour le boutton pour créer une nouvelle partie
        private void Button_Nv_Partie_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            Console.WriteLine("Buton_Nv_Partie");
            Frame.Navigate(typeof(PageNouvPartie));
        }

        // Fonction pour le boutton pour charger une partie
        private void Button_Ch_Partie_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            Console.WriteLine("Button_Ch_Partie");
        }
    }
}
