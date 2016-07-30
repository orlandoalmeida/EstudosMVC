using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Intermediario.Models
{
    public class Professor
    {
        [Key Column(Order = 0)]
        public int IDProfessor { get; set; }

        [Required (ErrorMessage = "Digite o nome do professor")]
        [MinLength (8, ErrorMessage ="Tamanho minimo 8 Caracteres")]
        public string Nome { get; set; }

        public decimal? Salario { get; set; }

        public  bool Disponivel { get; set; }

        [Required (ErrorMessage = "Informe a disciplina ministrada pelo professor")]
        public string Disciplina { get; set; }

        //chave estrangeira
        public List<Aluno> Alunos { get; set; }

        public  List<Topico> Topicos { get; set; }
    }
}