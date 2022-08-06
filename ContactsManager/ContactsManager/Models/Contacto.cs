using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsManager.Models
{
    public class Contacto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}