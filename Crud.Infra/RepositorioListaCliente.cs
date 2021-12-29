using Crud.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crud.Infra
{
    public class RepositorioListaCliente : IRepositorioListaCliente
    
    {
        public RepositorioListaCliente repositorioCliente;

        public void Deletar( DadosCliente dadosCliente)
        {
            var indice = ListaDeClientes.Instance.Listagem.FindIndex(x => x.Id == dadosCliente.Id);

            ListaDeClientes.Instance.Listagem.RemoveAt(indice);

            //for (int i = 0; i < ListaDeClientes.Instance.Listagem.Count; i++)
            //{
            //    if (dadosCliente.Id == ListaDeClientes.Instance.Listagem[i].Id || dadosCliente.Id == 0)
            //    {
            //        ListaDeClientes.Instance.Listagem.RemoveAt(i);
            //    }
            //}
            
        }

        public void Salvar(DadosCliente dadosCliente)
        {
            var maior = decimal.Zero;
            if (ListaDeClientes.Instance.Listagem.Any())
            {
                maior = ListaDeClientes.Instance.Listagem.Max(x => x.Id);
            }
            
            dadosCliente.Id = (int)(maior + decimal.One);
            ListaDeClientes.Instance.Listagem.Add(dadosCliente);
        }

        public void Editar(DadosCliente dadosCliente)
        {
            var indice = ListaDeClientes.Instance.Listagem.FindIndex(x => x.Id == dadosCliente.Id);

            ListaDeClientes.Instance.Listagem[indice] = dadosCliente;


            //for (int i = 0; i < ListaDeClientes.Instance.Listagem.Count; i++)
            //{
            //    if(dadosCliente.Id == ListaDeClientes.Instance.Listagem[i].Id)
            //    {
            //        ListaDeClientes.Instance.Listagem[i].Nome = dadosCliente.Nome;
            //        ListaDeClientes.Instance.Listagem[i].Email = dadosCliente.Email;
            //        ListaDeClientes.Instance.Listagem[i].Celular = dadosCliente.Celular;
            //        ListaDeClientes.Instance.Listagem[i].CPF = dadosCliente.CPF;
            //    }
            //}
        }
        public List<DadosCliente> ObterTodos()
        {
            return ListaDeClientes.Instance.Listagem;
        }
         public DadosCliente ObterSomenteUm(int pegarId)

        {
            return ListaDeClientes
                .Instance
                .Listagem
                .FirstOrDefault(x => x.Id == pegarId);
           
        }
    }
}
