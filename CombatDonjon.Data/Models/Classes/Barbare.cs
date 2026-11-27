namespace Projet_WinUI_CombatDonjon.Data.Models.Classes
{
    public class Barbare : ClasseJoueur
    {
        public override string? ClasseNom
        {
            get
            {
                return "Barbare";
            } 
            set
            {
                ClasseNom = "Barbare";
            }
        }

        public override float Pv => 30.0f;
        public override float Attaque => 5.0f;
        public override float Defense => 0.0f;
        public override float Esquive => 0.0f;
        public override float Acc => 10.0f;
    }
}
