using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Domain
{
    public interface IntRepositorioListaCliente
    {
        void Salvar(DadosCliente dadosCliente);
        void Deletar( int aux);
        void Editar(DadosCliente dadosCliente, int aux);

    }
}




