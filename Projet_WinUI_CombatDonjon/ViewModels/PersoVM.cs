using Projet_WinUI_CombatDonjon.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Projet_WinUI_CombatDonjon.ViewModels;

public class PersoVM : ValidableViewModel
{
    private readonly Joueur _joueur;

    public PersoVM(Joueur joueur)
    {
        _joueur = joueur;
        _errors.Add(nameof(Nom), new ObservableCollection<ValidationResult>());
        Validate(Nom, nameof(Nom));
    }

    public int Id => _joueur.Id;

    [Required(ErrorMessage = "Le nom est obligatoire.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Le nom doit contenir entre 2 et 50 caractères.")]
    [RegularExpression(@"^[\p{L} '’-]+$", ErrorMessage = "Le nom ne peut contenir que des lettres, des espaces, des traits d'union et des apostrophes.")]
    public string Nom
    {
        get { return _joueur.Nom; }
        set
        {
            if (_joueur.Nom != value && Validate(value))
            {
                _joueur.Nom = value;
                RaisePropertyChanged();
            }
        }
    }

    public ClasseJoueur Classe
    {
        get { return _joueur.Classe; }
        set
        {
            if (_joueur?.Classe != value)
            {
                _joueur.Classe = value;
                RaisePropertyChanged();
            }
        }
    }
}
