using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Intermediario.Models
{
    public class InicializaBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            //Criar alguns dados no banco
            new List<Professor>
            {
                new Professor
                {
                     Nome= "Orlando Estefano de Almeida",
                    Disciplina = "C#",
                    Salario = 5000,
                    Disponivel = true,
                    Alunos = new List<Aluno>{ },
                    Topicos =  new List<Topico> { }
                }
            };
            base.Seed(context);
        }
    }
}