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
     
        
        public void Deletar( int aux)
        {
            ListaDeClientes.Instance.Listagem.RemoveAt(aux);
        }

        public void Salvar(DadosCliente dadosCliente)
        {
            ListaDeClientes.Instance.Listagem.Add(dadosCliente);
        }

        public void Editar(DadosCliente dadosCliente, int aux)
        {
            ListaDeClientes.Instance.Listagem[aux].Nome = dadosCliente.Nome;
            ListaDeClientes.Instance.Listagem[aux].Email = dadosCliente.Email;
            ListaDeClientes.Instance.Listagem[aux].Celular = dadosCliente.Celular;
            ListaDeClientes.Instance.Listagem[aux].CPF = dadosCliente.CPF;
        }
    }
}
