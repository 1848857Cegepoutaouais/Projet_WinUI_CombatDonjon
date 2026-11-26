using Projet_WinUI_CombatDonjon.Data.Models.Classes;

namespace Projet_WinUI_CombatDonjon.Data.Models
{
    public abstract class ClasseJoueur
    {
        public abstract string? ClasseNom { get; set; }
        
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

        /// <summary>
        /// Fontion pour transformé l'Enum TypeClasse en un objet Classe
        /// </summary>
        /// <param name="typeClasse"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">C'est si la classe n'existe pas</exception>
        public static ClasseJoueur ConvertEnumTypeClasseToClasse(TypeClasse typeClasse)
        {
            switch (typeClasse)
            {
                case TypeClasse.Barbare: return new Barbare();
                case TypeClasse.Chasseur: return new Chasseur();
                case TypeClasse.Mage: return new Mage();
                default: throw new NotImplementedException("La classe n'existe pas ou n'a pas été implémenté dans ClasseJoueur");
            }
        }

        public static TypeClasse ConvertClasseToEnumTypeClasse(ClasseJoueur classeJoueur)
        {
            if (classeJoueur.GetType() == typeof(Barbare)) { return TypeClasse.Barbare; }
            else if (classeJoueur.GetType() == typeof(Chasseur)) { return TypeClasse.Chasseur; }
            else if (classeJoueur.GetType() == typeof(Mage)) { return TypeClasse.Mage; }
            else { throw new NotImplementedException("La classe de joueur n'existe pas"); }
        }
    }
}
