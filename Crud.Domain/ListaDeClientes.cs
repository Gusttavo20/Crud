using System;
using System.Collections.Generic;
namespace Crud.Domain
{
    public class ListaDeClientes
    {
        public List<DadosCliente> Listagem { get; set; }

        private static readonly Lazy<ListaDeClientes>
            lazy = new Lazy<ListaDeClientes>(() => new ListaDeClientes());

        public static ListaDeClientes Instance { get { return lazy.Value; } }

        public ListaDeClientes()
        {
            Listagem = new List<DadosCliente> {
               
            };
        }
    }
}
