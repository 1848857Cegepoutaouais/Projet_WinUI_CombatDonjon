using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public interface IPartieDataProvider
    {
        List<Partie> GetParties();

        void AjouterPartie(Partie partie);
        void SupprimerPartie(Partie partie);
    }
}
