using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Data em formato incorrto")]
        [Required(ErrorMessage = "O Campo Data de Lnacamento é obrigtório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato incorreto")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracters"), Required(ErrorMessage = "O Campo Genero é obrigatório")]
        public string Genero { get; set; }
        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[1-5]*$", ErrorMessage = "Somente números")]
        public int Avaliacao { get; set; }
    }
}