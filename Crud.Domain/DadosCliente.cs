using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Domain
{
   
    public class DadosCliente
    {

        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string CPF { get; set; }

        public DadosCliente()
        {
            
        }
        public DadosCliente(string nome, string email, string celular, string cpf, int id)
        {
            Nome = nome;
            Email = email;  
            Celular = celular;
            CPF = cpf;
            Id = id;
        }
    }
}