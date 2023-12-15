using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    public class PagamentoComCheque : TipoDePagamento
{
    public int Banco { get; set; }
    [Key]
    public string? NumeroDoCheque { get; set; }
    public string? NomeDoBanco {get; set;}
}
}