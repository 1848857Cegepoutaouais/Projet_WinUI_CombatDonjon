using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Projet_WinUI_CombatDonjon.Models;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

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
