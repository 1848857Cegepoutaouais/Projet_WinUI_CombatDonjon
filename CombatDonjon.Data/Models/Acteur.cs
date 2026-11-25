namespace Projet_WinUI_CombatDonjon.Data.Models
{
    public class Acteur
    {
        // Nom du joueur ou du monstre
        public string Nom { get; set; }

        // Points de vie du joueur ou du monstre
        public float Pv { get; set; }

        // Stat d'attaque du joueur ou du monstre
        public float Attaque { get; set; }

        // Stat de défense du joueur ou du monstre
        public float Defense { get; set; }

        // Stat d'esquive du joueur ou du monstre
        public float Esquive { get; set; }

        // Stat de précision du joueur ou du monstre
        public float Acc { get; set; }

        // Points de exp du joueur ou l'xp que le monstre donne lorsqu'il est vaincu
        public float Xp { get; set; }
    }
}
