// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using Projet_WinUI_CombatDonjon.Data.Models;

namespace Projet_WinUI_CombatDonjon.ViewModels
{
    public  class VMCombat : ValidableViewModel
    {
        private readonly Combat _combat;
        public VMCombat(Combat combat)
        {
            _combat = combat;
        }

        public int CombatId => _combat.CombatId;
    }
}
