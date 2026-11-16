using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Projet_WinUI_CombatDonjon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.Data
{
    public interface InterfaceDonjonDataProvider
    {
        // Méthodes de gestion des joueurs
        List<Joueur> GetJoueurs();
        void AjouterJoueur(Joueur joueur);
        void SupprimerJoueur(int joueurId);
        void ModifierJoueur(int id, string nouvNom, ClasseJoueur nouvClasse);

        // Méthodes de gestion des monstres

        
    }
}
