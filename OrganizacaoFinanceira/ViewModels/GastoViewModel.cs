using OrganizacaoFinanceira.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrganizacaoFinanceira.ViewModels;

public class GastoViewModel
{

    [Required(ErrorMessage = "O Valor é obrigatório")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "A data do gasto é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime DataGasto { get; set; }

    [Required(ErrorMessage = "A Categoria do Gasto é obrigatório")]
    public Categoria.Gasto CategoriaGasto { get; set; }

    [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres.")]
    public string? Descricao { get; set; }
}