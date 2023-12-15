using System.ComponentModel.DataAnnotations;

namespace estoque.Models {

    public class Transportadora
{
    [Display(Name="Código Transportadora")]

    public int Id { get; set; }
    public string? Nome { get; set; }
    public virtual ICollection<NotaDeVenda>? NotasDeVenda { get; set; }// = new List<NotaDeVenda>();
}
}