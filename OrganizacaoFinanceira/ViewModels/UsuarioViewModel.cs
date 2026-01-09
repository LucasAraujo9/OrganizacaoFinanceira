using System.ComponentModel.DataAnnotations;

namespace OrganizacaoFinanceira.ViewModels;

public class UsuarioViewModel
{
    [Required(ErrorMessage = "O Nome é obrigatorio")]
    [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "Email inválido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória.")]
    [StringLength(50, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 50 caracteres.")]
    public string Senha { get; set; }


    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}
