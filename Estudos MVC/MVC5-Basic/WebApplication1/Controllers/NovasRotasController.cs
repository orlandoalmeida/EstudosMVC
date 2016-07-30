using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [RoutePrefix("novasrotas")]
    public class NovasRotasController : Controller
    {
        // GET: NovasRotas
        // passagem de parametro
        [Route("index/{nascimento:datetime}")]

        public string Index(DateTime nascimento)
        {
            return string.Format("Data de nascimento [0:dd/MM/yyyy]", nascimento);
        }

        // passagem de parametro
        [Route("dados/{nome}/{idade:int:min(18):max(99)}")]
        public string GetDados(string nome, int idade = 20)
        {
            return HttpUtility.HtmlEncode(string.Format("Bem vindo {0} com idade {1}", nome, idade));
        }

        // passagem de parametro
        [Route("preco/{preco:int:min(20)}")]
        public string GetPreco (int preco)
        {
            return "preco do produto é " + preco;
        }

        // passagem de parametro
        [Route("cliente/{id}")]
        public string GetCliente(int Id)
        {
            return "código do cliente " + Id;
        }

    }
}