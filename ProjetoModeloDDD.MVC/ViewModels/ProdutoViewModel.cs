using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} de carecteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(Decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public string Valor { get; set; }


        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public ClienteViewModel Cliente;
    }
}