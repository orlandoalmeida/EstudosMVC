using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Intermediario.Models
{
    public class Aluno
    {
        [Key]
        public int Matricula { get; set; }

        [Display (Name = "Professor")]
        public int IDProfessor { get; set; }

        [Required (ErrorMessage = "Digite o nome do aluno")]
        [MaxLength (50), MinLength (5)]
        public string NomeAluno { get; set; }

        [MaxLength (250)]
        public  string Email{ get; set; }

        public bool Aprovador { get; set; }

        // Lazy Loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}