using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinUI_CombatDonjon.Models
{
    public class Partie
    {
        public int PartieId { get; set; }

        public string PartieNom {  get; set; }

        public Donjon PartieDonjon { get; set; }

        public List<Joueur> Joueurs { get; set; }

        public Partie(int partieId, string partieNom, Donjon donjon, List<Joueur> joueurs)
        {
            PartieId = partieId;
            PartieNom = partieNom;
            PartieDonjon = donjon;
            Joueurs = joueurs;
        }
        
    }
}
