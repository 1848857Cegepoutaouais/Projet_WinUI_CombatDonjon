namespace Projet_WinUI_CombatDonjon.Data.Models
{
    public class Partie
    {
        public int PartieId { get; set; }
        public string PartieNom {  get; set; }
        public Donjon PartieDonjon { get; set; }
        public List<Joueur> Joueurs { get; set; }
        public DateTime DernierLancee { get; set; }

        public int DonjonId { get; set; }


        public Partie (string partieNom, Donjon donjon, List<Joueur> joueurs)
        {
            PartieNom = partieNom;
            PartieDonjon = donjon;
            Joueurs = joueurs;
        }
        public Partie(int partieId, string partieNom, Donjon donjon, List<Joueur> joueurs)
        {
            PartieId = partieId;
            PartieNom = partieNom;
            PartieDonjon = donjon;
            Joueurs = joueurs;
        }
        
    }
}
