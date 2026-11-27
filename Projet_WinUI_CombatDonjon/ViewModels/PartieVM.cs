using Projet_WinUI_CombatDonjon.Data.Models;
using Projet_WinUI_CombatDonjon.Data.Models.Classes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.ViewModels
{
    public class PartieVM : ValidableViewModel
    {
        private readonly Partie _partie;

        public PartieVM(Partie partie)
        {
            _partie = partie;
            _errors.Add(nameof(PartieNom), new ObservableCollection<ValidationResult>());
            Validate(PartieNom, nameof(PartieNom));
        }

        public int PartieID => _partie.PartieId;

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit contenir entre 2 et 50 caractères.")]
        [RegularExpression(@"^[\p{L} '’-]+$", ErrorMessage = "Le nom ne peut contenir que des lettres, des espaces, des traits d'union et des apostrophes.")]
        public string PartieNom
        {
            get => _partie.PartieNom;
            set
            {
                if (_partie.PartieNom != value && Validate(value))
                {
                    _partie.PartieNom = value;
                    RaisePropertyChanged(nameof(PartieNom));
                }
            }
        }

        public Donjon PartieDonjon
        {
            get => _partie.PartieDonjon;
            set
            {
                if (_partie.PartieDonjon != value)
                {
                    _partie.PartieDonjon = value;
                    RaisePropertyChanged();
                }
            }
        }

        public List<Joueur> Joueur
        {
            get => _partie.Joueurs;
            set
            {
                if (_partie.Joueurs != value)
                {
                    _partie.Joueurs = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
