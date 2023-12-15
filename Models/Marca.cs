using System.ComponentModel.DataAnnotations;
namespace estoque.Models {

    public class Marca
    
{
    [Display(Name="Código Marca")]
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    
    public virtual ICollection<Produto>? Produtos { get; set; }//= new List<Produto>();
}
}