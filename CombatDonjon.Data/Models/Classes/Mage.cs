namespace Projet_WinUI_CombatDonjon.Data.Models.Classes
{
    public class Mage : ClasseJoueur
    {
        public override string? ClasseNom
        {
            get
            {
                return "Mage";
            }
            set
            {
                ClasseNom = "Mage";
            }
        }
        public override float Pv => 20.0f;
        public override float Attaque => 15.0f;
        public override float Defense => 0.0f;
        public override float Esquive => 0.0f;
        public override float Acc => 10.0f;

    }
}