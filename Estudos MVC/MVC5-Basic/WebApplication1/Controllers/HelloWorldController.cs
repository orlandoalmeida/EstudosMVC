using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        //// GET: HelloWorld
        //public string Index()
        //{
        //    return "Hello Wrold MVC";
        //}

        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/TesteNegrito
        public string TesteNegrito ()
        {
            return "Texto <b> Texto em negrito </b><br> retorno do Controller";
        }

        // GET: HelloWorld/GetJson
        public JsonResult GetJson()
        {
            var produto = new
            {
                ID = 12,
                Nome = "bicicleta",
                Qtd = 10
            };
            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        // GET: HelloWorld/GetDados?nome=Orlando&idade=22
        public string GetDados(string nome = "Desconhecido", int idade = 0) //caso nao seja nada entra como deffalt esses parametros
        {
            return HttpUtility.HtmlEncode(string.Format("Bem Vindo {0} com idade {1}", nome, idade));
            // Protege os parametros passados na barra de url do browser 
        }
    }
}