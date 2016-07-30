using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Intermediario.Models
{
    public class Topico
    {
        [Key]
        public int IDTopico { get; set; }

        [Display(Name = "Professor")]
        public int IDProfessor { get; set; }

        [Required (ErrorMessage ="Digite a descricao do topico")]
        [MaxLength (100)]
        public string Descricao { get; set; }

        // Lazy Loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}