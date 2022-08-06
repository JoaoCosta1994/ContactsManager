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
            return View("Index");
        }
        [HttpGet]
        public ViewResult AdicionarContacto()
        {
            return View("AdicionarContacto");
        }
        [HttpPost]
        public ViewResult AdicionarContacto(Contacto resposta )
        {
            listatelefonica.AdicionarContacto(resposta);
            return View("adicionado",resposta);
        }

    }  
}