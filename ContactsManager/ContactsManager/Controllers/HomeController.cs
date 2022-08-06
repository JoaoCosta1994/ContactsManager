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
        public bool verifica = true;
        [HttpGet]
        public ViewResult Index()
        {
           
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
            listatelefonica.AdicionarContacto(conc);
            return View("adicionado",conc);
        }

        public ViewResult eliminado()
        {
           
            return View("eliminado");
        }

    }  
}