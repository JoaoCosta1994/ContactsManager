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
        public ViewResult Index()
        {
           
            return View("Index",listatelefonica.ListaTelefonica);
        }
        [HttpGet]
        public ViewResult AdicionarContacto()
        {
            return View("AdicionarContacto");
        }
        [HttpPost]
        public ViewResult AdicionarContacto(Contacto resposta )
        {
            Contacto conc = new Contacto(resposta.ID, resposta.Nome, resposta.Telefone, resposta.Email);
            listatelefonica.AdicionarContacto(conc);
            return View("adicionado",conc);
        }

    }  
}