using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models;

public class Categoria
{
    private string nome = string.Empty;

    [Required(ErrorMessage = "Informe o nome da categoria.")]
    [StringLength(50, MinimumLength = 3,
        ErrorMessage = "O nome deve possuir entre 3 e 50 caracteres.")]
    public string Nome
    {
        get => nome;
        set => nome = value?.Trim() ?? string.Empty;
    }

    [Range(0, 100000,
        ErrorMessage = "A quantidade deve estar entre 0 e 100.000.")]
    public int Quantidade { get; set; }
}
