using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactsManager.Models;

namespace ContactsManager.Controllers
{
    
    public class HomeController : Controller
    {
        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }
        public bool verifica = true;
        [HttpGet]
        public ViewResult Index()
        {
            if (listatelefonica.ListaTelefonica.Count() == 0)
            {
                Contacto conc = new Contacto(0, "João Costa", "932353371", "joaocostaworks@gmail.com", verifica);
                listatelefonica.AdicionarContacto(conc);
            }
            return View("Index",listatelefonica.ListaTelefonica);
        }

        [HttpPost]
        public ViewResult Index(Contacto resposta)
        {
            verifica = false;
            Contacto conc = new Contacto(resposta.ID, resposta.Nome, resposta.Telefone, resposta.Email,verifica);
            listatelefonica.RemoverContacto(conc);
            return View("eliminado", resposta);
        }

        [HttpGet]
        public ViewResult AdicionarContacto()
        {
            return View("AdicionarContacto");
        }
        [HttpPost]
        public ViewResult AdicionarContacto(Contacto resposta )
        {
            verifica = true;
            Contacto conc = new Contacto(resposta.ID, resposta.Nome, resposta.Telefone, resposta.Email,verifica);
            if (resposta.Nome == null || resposta.Telefone == null || resposta.Email == null || contemLetras(resposta.Telefone)==true)
                return View("erro");
            if (resposta.Nome.Length > 5 && resposta.Telefone.Length == 9 && (resposta.Email.Contains("@")))
            {
                listatelefonica.AdicionarContacto(conc);
                return View("adicionado", conc);
            }
            else
                return View("erro");
        }

        public ViewResult eliminado()
        {
           
            return View("eliminado");
        }
        public ViewResult erro()
        {

            return View("erro");
        }

        public ViewResult detalhes()
        {

            return View("detalhes",listatelefonica.ListaTelefonica);
        }

    }  
}