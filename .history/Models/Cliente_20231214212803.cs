using System.ComponentModel.DataAnnotations;

namespace estoque.Models {

    public class Cliente {

        [Display(Name="Código Cliente")]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public virtual ICollection<NotaDeVenda>? NotasDeVenda { get; set; }// = new List<NotaDeVenda>();
        
    }
}