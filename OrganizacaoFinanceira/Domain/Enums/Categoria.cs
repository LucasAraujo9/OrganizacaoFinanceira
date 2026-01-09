using System.ComponentModel;

namespace OrganizacaoFinanceira.Domain.Enums
{
    public class Categoria
    {
        public enum Gasto : byte
        {
            [Description ("Cartao")]
            cartao = 1,
            [Description("Moradia")]
            Moradia = 2,
            [Description("Transporte")]
            Transporte = 3,
            [Description("Lazer")]
            Lazer = 4,
            [Description("Outros")]
            Outros = 99
        }

        public enum Recebivel : byte
        {
            [Description("Salario")]
            Salario = 1,
            [Description("Dividendo")]
            Dividendo = 2,
            [Description("Outros")]
            Outros = 99
        }
    }
}
