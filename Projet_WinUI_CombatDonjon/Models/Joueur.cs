using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinUI_CombatDonjon.Models
{
    public class Joueur : Acteur
    {
        public int Id { get; set; }
        // Points de vie maximum du joueur pour ne pas pouvoir guérir plus que les points de vie de départ
        public float MaxPv { get; set; }

        // Classe du joueur 
        public ClasseJoueur Classe {  get; set; }

        // Niveau du joueur 
        public int Niveau { get; set; }

        /// <summary>
        /// Constructeur pour créer un nouveau joueur
        /// </summary>
        /// <param name="nom"> Nom du personnage</param>
        /// <param name="classe"> Classe du personnage</param>
        public Joueur(string nom = "", ClasseJoueur classe = null)
        {
            Nom = nom;
            Classe = classe;
            Niveau = 1;
            Pv = Classe.Pv * Niveau;
            Attaque = Classe.Attaque * Niveau;
            Defense = Classe.Defense * Niveau;
            Esquive = Classe.Esquive * Niveau;
            Acc = Classe.Acc * Niveau;
            Xp = 0;
            MaxPv = Classe.Pv * Niveau;
        }

        public Joueur(string nom, ClasseJoueur classe, float pv, float attaque, float defense, float esquive, float acc, float xp, int niveau)
        {
            Nom = nom;
            Classe = classe;
            Pv = pv;
            Attaque = attaque;
            Defense = defense;
            Esquive = esquive;
            Acc = acc;
            Xp = xp;
            Niveau = niveau;
            MaxPv = Classe.Pv * Niveau;
        }

    }
}
