namespace Projet_WinUI_CombatDonjon.Data.Models.Classes
{
    public class Chasseur : ClasseJoueur
    {
        public override string? ClasseNom
        {
            get
            {
                return "Chasseur";
            }
            set
            {
                ClasseNom = "Chasseur";
            }
        }
        public override float Pv => 25.0f;
        public override float Attaque => 10.0f;
        public override float Defense => 0.0f;
        public override float Esquive => 5.0f;
        public override float Acc => 12.0f;

    }
}
