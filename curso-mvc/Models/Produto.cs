using System.ComponentModel.DataAnnotations;

namespace curso_mvc.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo descrição é obrigatório")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        
    }
}