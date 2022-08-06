using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsManager.Models
{
    public class listatelefonica
    {
        private static List<Contacto> LISTA = new List<Contacto>();
        public static void AdicionarContacto (Contacto resposta)
        {
            LISTA.Add(resposta);
        }

        public static IEnumerable<Contacto> ListaTelefonica
        {
            get
            {
                return LISTA;
            }
        }
       
    }
}