using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Accessibility;
using Crud.Domain;
using Crud.Infra;
using Ninject;
using Ninject.Parameters;
using System.Text;

namespace Crud.UI
{
    public partial class FomsCadastro : Form
    {
        
         DadosCliente dadosCliente = new DadosCliente();  
        private IRepositorioListaCliente RepositorioListaCliente;
         
        public FomsCadastro(IRepositorioListaCliente _repositorioListaCliente, DadosCliente dados) {

            RepositorioListaCliente = _repositorioListaCliente;
            dadosCliente = dados;
           
            InitializeComponent();
 
        }
        private void FomsCadastro_Load(object sender, EventArgs e)
        {

            if (dadosCliente.Id >= 0)
            {

                textId.Text = dadosCliente.Id.ToString();
                textNome.Text = dadosCliente.Nome;
                textEmail.Text = dadosCliente.Email;
                maskcelular.Text = dadosCliente.Celular;
                maskCPF.Text = dadosCliente.CPF;

            }
            else
            {
                textId.Text = "0";
            }
        }
        public bool TodosOsCamposPreenchidosCorretamente()
        {
            if (RepositorioListaCliente.ObterTodos().Count < 0)
            {
                if (!String.IsNullOrWhiteSpace(textNome.Text)) return true;
                if (!String.IsNullOrWhiteSpace(textEmail.Text)) return true;
                if (!String.IsNullOrWhiteSpace(maskcelular.Text)) return true;
                if (!String.IsNullOrWhiteSpace(maskCPF.Text)) return true;
                
                return false;

            }
            else
            {
                if (String.IsNullOrWhiteSpace(textNome.Text)) return true;
                if (String.IsNullOrWhiteSpace(textEmail.Text)) return true;
                if (String.IsNullOrEmpty(maskcelular.Text)) return true;
                if (String.IsNullOrEmpty(maskCPF.Text)) return true;
                
                return false;
            }

        }

        public static bool ValidacaoEmail(string email)
        {
            bool Validar = false;
            int Analisar = email.IndexOf("@gmail.com");

            if (Analisar > 0)
            {
                if (email.IndexOf("@gmail.com", Analisar + 1) > 0)
                {
                    return Validar;
                }

                int i = email.IndexOf(".", Analisar);
                if (i - 1 > Analisar)
                {
                    if (i + 1 < email.Length)
                    {
                        string r = email.Substring(i + 1, 1);
                        if (r != ".")
                        {
                            Validar = true;
                        }
                    }
                }
            }
            
            return Validar;
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
            
            if (!TodosOsCamposPreenchidosCorretamente() & 
                (ValidacaoEmail(textEmail.Text) & 
                (maskCPF.MaskCompleted) & 
                (maskcelular.MaskCompleted)))
            {
                if (textId.Text != "0")
                {
                    dadosCliente.Nome = textNome.Text.ToString();
                    dadosCliente.Email = textEmail.Text.ToString();
                    dadosCliente.CPF = maskCPF.Text.ToString();
                    dadosCliente.Celular = maskcelular.Text.ToString();

                    RepositorioListaCliente.Editar(dadosCliente);
                    DialogResult = DialogResult.OK;
                }
                 else 
                {
                    dadosCliente.Nome = textNome.Text.ToString();
                    dadosCliente.Email = textEmail.Text.ToString();
                    dadosCliente.CPF = maskCPF.Text.ToString();
                    dadosCliente.Celular = maskcelular.Text.ToString();

                    RepositorioListaCliente.Salvar(dadosCliente);
                    DialogResult = DialogResult.OK;

                }
            }
            else
            {
                MessageBox.Show("Informe todos os campos corretamente!\n" +
                    "Verifique se o seu email contém '@gmail.com' \n" +
                    "Os campos 'CELULAR' e 'CPF' devem ser preenchidos completamente!", 
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
        }
        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}