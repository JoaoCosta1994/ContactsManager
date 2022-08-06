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
        public static void RemoverContacto(Contacto resposta)
        {
            //foreach (var item in LISTA)
            //{
          //  LISTA.RemoveAll((c) => c.ID.ToString() == resposta.ID.ToString());
            //}

            var contList = LISTA;

            var IDs = contList.Where(a => a.ID == resposta.ID).ToList();

            foreach (var ID in IDs)
            {
                contList.Remove(ID);
            }

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

