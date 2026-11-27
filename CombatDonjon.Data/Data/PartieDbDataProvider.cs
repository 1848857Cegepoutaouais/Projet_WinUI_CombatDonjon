using Projet_WinUI_CombatDonjon.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_WinUI_CombatDonjon.Data.Data
{
    public class PartieDbDataProvider : IPartieDataProvider
    {
        private readonly CombatDonjonDbContext _context;

        public PartieDbDataProvider(CombatDonjonDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Partie> GetParties()
        {
            return _context.Parties
                .OrderBy(p => p.DernierLancee)
                .ThenByDescending(p => p.PartieNom).ToList();
        }

        public void AjouterPartie(Partie partie)
        {
            ArgumentNullException.ThrowIfNull(partie);

            partie.PartieId = _prochainIdPartie++;
            _parties.Add(partie);
        }
    }
}
