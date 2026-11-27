using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public interface IJoueurDataProvider
    {
        List<Joueur> GetJoueurs();
        List<ClasseJoueur> GetClasseJoueurs();
        void AjouterJoueur(Joueur joueur);
        void SupprimerJoueur(int joueurId);
        void ModifierJoueur(int id, string nouvNom, ClasseJoueur nouvClasse);

    }
}
