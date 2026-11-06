using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models;

public class Produto
{
    private string nome = string.Empty;

    [Required(ErrorMessage = "Informe o nome do produto.")]
    public string Nome
    {
        get => nome;
        set => nome = value?.Trim() ?? string.Empty;
    }

    [Range(typeof(decimal), "0.01", "79228162514264337593543950335",
        ErrorMessage = "Informe um preço maior que zero.")]
    public decimal Preco { get; set; }

    public int Quantidade { get; set; }
}
