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
        
        private static int ID_creator = 0;
        public Contacto()
        {
            
        }
        public Contacto(int id, string nome, string telefone, string email)
        {
            this.ID = ID_creator;
            ID_creator++;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

    }
    
}