using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Livro
    {
        [Key]
        public int IDLivro { get; set; }

        [Required(ErrorMessage ="Digite o titulo do livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Digite o nome do autor do livro")]
        [StringLength(100, ErrorMessage = "O tamanho maximo de caracteres é {1}", MinimumLength = 6)]
        public string Autor { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public bool Disponivel { get; set; }
    }
}