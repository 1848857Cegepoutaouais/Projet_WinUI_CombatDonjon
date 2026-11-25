using Projet_WinUI_CombatDonjon.Data.Models.Classes;

namespace Projet_WinUI_CombatDonjon.Data.Models
{
    public class Joueur : Acteur
    {
        public int Id { get; set; }
        // Points de vie maximum du joueur pour ne pas pouvoir guérir plus que les points de vie de départ
        public float MaxPv { get; set; }

        // Classe du joueur 
        public ClasseJoueur Classe { get; set; }

        // Niveau du joueur 
        public int Niveau { get; set; }

        public bool GodMode { get; set; } = false;

        /// <summary>
        /// Constructeur pour créer un nouveau joueur
        /// </summary>
        /// <param name="nom"> Nom du personnage</param>
        /// <param name="classe"> Classe du personnage dans l'enum TypeClasse</param>
        public Joueur(string nom, ClasseJoueur classe)
        {
            Nom = nom;
            Classe = classe;
            Niveau = 1;
            CalculStat();
        }

        public Joueur(string nom, TypeClasse classe, float pv, float attaque, float defense, float esquive, float acc, float xp, int niveau)
        {
            Nom = nom;
            Classe = ClasseJoueur.ConvertEnumClasseToClass(classe);
            Pv = pv;
            Attaque = attaque;
            Defense = defense;
            Esquive = esquive;
            Acc = acc;
            Xp = xp;
            Niveau = niveau;
            MaxPv = Pv * Niveau;
            GodMode = true;
        }

        public Joueur()
        {
            Nom = "Default ou Érreur";
            Classe = new Barbare();
            Niveau = 1;
            CalculStat();
        }

        /// <summary>
        /// Fonction qui calcul les stats du personnage, soit à la création ou lors d'un level-up
        /// </summary>
        public void CalculStat()
        {
            if (!GodMode)
            {
                Pv = Classe.Pv * Niveau;
                Attaque = Classe.Attaque * Niveau;
                Defense = Classe.Defense * Niveau;
                Esquive = Classe.Esquive * Niveau;
                Acc = Classe.Acc * Niveau;
                Xp = 0;
                MaxPv = Classe.Pv * Niveau;
            } else
            {
                Pv = MaxPv * Niveau;
                Attaque = Attaque * Niveau;
                Defense = Defense * Niveau;
                Esquive = Esquive * Niveau;
                Acc = Acc * Niveau;
                Xp = 0;
                MaxPv = MaxPv * Niveau;
            }
        }

        /// <summary>
        /// Fonction qui gère le gain d'xp pour les personnages
        /// </summary>
        /// <param name="gainXp">Le nombre d'xp que le personnage gagne</param>
        public void GainXp(float gainXp)
        {
            Xp += gainXp;
            if (Xp >= 100 * Niveau)
            {
                LvUp();
            }
        }

        /// <summary>
        /// Fonction pour faire le level-up du personnage
        /// </summary>
        public void LvUp()
        {
            Xp -= 100 * Niveau;
            Niveau += 1;
            CalculStat();
        }
    }
}
