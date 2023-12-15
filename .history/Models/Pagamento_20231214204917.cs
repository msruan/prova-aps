using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    public class Pagamento
{
    public int Id { get; set; }
    public DateTime DataLimite { get; set; }
    public double Valor { get; set; }
    public bool Pago { get; set; }
    
    [Display(Name="Nota Fiscal")]
    public int NotaDeVendaId { get; set; }
    public virtual NotaDeVenda? NotaDeVenda { get; set; }
}
}
