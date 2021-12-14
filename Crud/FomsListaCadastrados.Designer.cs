
namespace Crud.UI
{
    partial class FomsListaCadastrados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtExcluir = new System.Windows.Forms.Button();
            this.btNovoUsuario = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.DataGridlistaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridlistaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtExcluir
            // 
            this.BtExcluir.BackColor = System.Drawing.Color.Red;
            this.BtExcluir.Location = new System.Drawing.Point(592, 239);
            this.BtExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(98, 34);
            this.BtExcluir.TabIndex = 1;
            this.BtExcluir.Text = "DELETAR";
            this.BtExcluir.UseVisualStyleBackColor = false;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click_1);
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btNovoUsuario.ForeColor = System.Drawing.Color.Black;
            this.btNovoUsuario.Location = new System.Drawing.Point(339, 240);
            this.btNovoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(142, 33);
            this.btNovoUsuario.TabIndex = 4;
            this.btNovoUsuario.Text = "NOVO USUÁRIO";
            this.btNovoUsuario.UseVisualStyleBackColor = false;
            this.btNovoUsuario.Click += new System.EventHandler(this.btNovoUsuario_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Yellow;
            this.btEditar.Location = new System.Drawing.Point(486, 238);
            this.btEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(101, 34);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // DataGridlistaCliente
            // 
            this.DataGridlistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridlistaCliente.Location = new System.Drawing.Point(-3, -1);
            this.DataGridlistaCliente.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DataGridlistaCliente.Name = "DataGridlistaCliente";
            this.DataGridlistaCliente.RowHeadersWidth = 51;
            this.DataGridlistaCliente.RowTemplate.Height = 29;
            this.DataGridlistaCliente.Size = new System.Drawing.Size(704, 236);
            this.DataGridlistaCliente.TabIndex = 6;
            
            // 
            // FomsListaCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 282);
            this.Controls.Add(this.DataGridlistaCliente);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovoUsuario);
            this.Controls.Add(this.BtExcluir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FomsListaCadastrados";
            this.Text = "FomsListaCadastrados";
            this.Load += new System.EventHandler(this.FomsListaCadastrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridlistaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridlistaCliente;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button btNovoUsuario;
        private System.Windows.Forms.Button btEditar;

    }
}