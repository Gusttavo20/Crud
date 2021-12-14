using System;
using System.Windows.Forms;
using Accessibility;
using Crud.Domain;
using Crud.Infra;

namespace Crud.UI
{
    public partial class FomsCadastro : Form
    {

        public DadosCliente dadosCliente;
        
        public FomsCadastro(DadosCliente dados = null) { 
            InitializeComponent();

            dadosCliente = dados ?? new DadosCliente();

            textNome.Text = dados.Nome;
            textEmail.Text = dados.Email;
            maskcelular.Text = dados.Celular;
            maskCPF.Text = dados.CPF;

        }
        public FomsCadastro()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja limpar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textNome.Text = " ";
                textEmail.Text = "";
                maskcelular.Text = "";
                maskCPF.Text = "";
            }

        }
        private void bt_Salvar_Click(object sender, EventArgs e)
        {

            dadosCliente.Nome = textNome.Text.ToString();
            dadosCliente.Email = textEmail.Text.ToString();
            dadosCliente.CPF = maskCPF.Text.ToString();
            dadosCliente.Celular = maskcelular.Text.ToString();

            if ((textNome.Text == string.Empty) || (textEmail.Text == string.Empty) || (!maskcelular.MaskCompleted) || (!maskCPF.MaskCompleted))
            {
                MessageBox.Show("Informe todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;

            }

        }

        private void FomsCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}