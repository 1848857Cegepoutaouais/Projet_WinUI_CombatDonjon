using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_WinUI_CombatDonjon.Models
{
    class Barbare:ClasseJoueur
    {
        public new float Pv => 30.0f;
        public new float Attaque => 5.0f;
        public new float Defense => 0.0f;
        public new float Esquive => 0.0f;
        public new float Acc => 10.0f;

    }
}
