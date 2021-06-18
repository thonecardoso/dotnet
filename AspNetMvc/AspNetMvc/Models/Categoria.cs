using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo descrição é obrigatório")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}