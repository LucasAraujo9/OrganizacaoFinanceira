using OrganizacaoFinanceira.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrganizacaoFinanceira.ViewModels;

public class RecebivelViewModel
{

    [Required(ErrorMessage = "O Valor é obrigatório")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "A data do recebido é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime DataRecebivel { get; set; }

    [Required(ErrorMessage = "A Categoria do Recebivel é obrigatório")]
    public Categoria.Recebivel CategoriaRecebivel { get; set; }

    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres.")]
    public string? Descricao { get; set; }
}
