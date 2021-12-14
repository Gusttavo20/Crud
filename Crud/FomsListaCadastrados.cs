using System;
using System.Windows.Forms;
using Crud.Domain;
using Crud.Infra;

namespace Crud.UI
{
    public partial class FomsListaCadastrados : Form
    {

        DadosCliente dadosCliente = new DadosCliente();
        IntRepositorioListaCliente repositorio = new RepositorioListaCliente();

        public FomsListaCadastrados()
        {
            InitializeComponent();
            repositorio.Salvar(new DadosCliente { });
            DataGridlistaCliente.DataSource = null;
            DataGridlistaCliente.DataSource = ListaDeClientes.Instance.Listagem;

            repositorio.Deletar(0);
            DataGridlistaCliente.DataSource = null;
            DataGridlistaCliente.DataSource = ListaDeClientes.Instance.Listagem;
        }

        private void FomsListaCadastrados_Load(object sender, EventArgs e)
        {

        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            //Instaciar outra form
            FomsCadastro telaCadastro = new FomsCadastro();

            //passar PARAMETROS vazio
            telaCadastro.dadosCliente = new DadosCliente
            {

            };

            //Diferenciar qual o botão foi acionado "Editar ou Novo Usuario"           
            //telaCadastro.EditarNovoUsuaro = false;

            if (telaCadastro.ShowDialog() == DialogResult.OK)
            {
                //Adicionar na lista
                repositorio.Salvar(telaCadastro.dadosCliente);

                //Atualizar DataGrid
                telaCadastro.Dispose();
                DataGridlistaCliente.DataSource = null;
                DataGridlistaCliente.DataSource = ListaDeClientes.Instance.Listagem;
            }

        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            var i = DataGridlistaCliente.CurrentRow;
            if (i == null)
            {
                MessageBox.Show("Selecione um cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Valor que o "DadosCliente" ira receber

                dadosCliente.Nome = DataGridlistaCliente.CurrentRow.Cells[0].Value.ToString();
                dadosCliente.Email = DataGridlistaCliente.CurrentRow.Cells[1].Value.ToString();
                dadosCliente.Celular = DataGridlistaCliente.CurrentRow.Cells[2].Value.ToString();
                dadosCliente.CPF = DataGridlistaCliente.CurrentRow.Cells[3].Value.ToString();
            }

            FomsCadastro telaEditar = new FomsCadastro(dadosCliente);

            //Diferenciar qual o botão foi acionado "Editar ou Novo Usuario"
            //telaEditar.EditarNovoUsuaro = true;(Codigo anterior)
            if (telaEditar.ShowDialog() == DialogResult.OK)
            {

                int aux = DataGridlistaCliente.CurrentRow.Index;

                repositorio.Editar(dadosCliente, aux);

                DataGridlistaCliente.DataSource = null;
                DataGridlistaCliente.DataSource = ListaDeClientes.Instance.Listagem;

               
            }
            telaEditar.Close();


        }

        private void BtExcluir_Click_1(object sender, EventArgs e)
        {
            //Verificar se alguma linha foi selecionada
            var i = DataGridlistaCliente.CurrentRow;
            if (i == null)
            {
                MessageBox.Show("Selecione um cliente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Selecionar a linha em um DataGrid
                var aux = DataGridlistaCliente.CurrentRow.Index;

                DialogResult YesNo = new DialogResult();
                YesNo = MessageBox.Show("Você tem certeza de que quer excluir esse cliente?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (YesNo == DialogResult.Yes)
                {
                    //Remover a linha
                    repositorio.Deletar(aux);
                }
                else
                {
                    return;
                }

            }
            //Atualizar DataGrid
            DataGridlistaCliente.DataSource = null;
            DataGridlistaCliente.DataSource = ListaDeClientes.Instance.Listagem;

        }

       
    }
}
