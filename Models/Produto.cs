using System.ComponentModel.DataAnnotations;
//using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    public class Produto
{
    [Display(Name="Código de Barras")]

    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    
    [Display(Name="Código Marca")]
    public int MarcaId { get; set; }
    public virtual Marca? Marca { get; set; }

    public virtual ICollection<Item>? Itens { get; set; } //= new List<Item>();//tlvz nao deva ter
}
}