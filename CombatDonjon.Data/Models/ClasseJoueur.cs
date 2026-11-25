using Projet_WinUI_CombatDonjon.Data.Models.Classes;

namespace Projet_WinUI_CombatDonjon.Data.Models
{
    public class ClasseJoueur
    {
        // Points de vie de base de la classe
        public float Pv { get; set; }

        // Stat d'attaque de base de la classe
        public float Attaque { get; set; }

        // Stat de défense de base de la classe
        public float Defense { get; set; }

        // Stat d'esquive de base de la classe
        public float Esquive { get; set; }

        // Stat de précision de base de la classe
        public float Acc { get; set; }

        public static ClasseJoueur ConvertEnumClasseToClass(TypeClasse typeClasse)
        {
            switch (typeClasse)
            {
                case TypeClasse.Barbare: return new Barbare();
                case TypeClasse.Chasseur: return new Chasseur();
                case TypeClasse.Mage: return new Mage();
                default: throw new NotImplementedException("La classe n'existe pas ou n'a pas été implémenté dans ClasseJoueur");
            }
        }
    }
}
