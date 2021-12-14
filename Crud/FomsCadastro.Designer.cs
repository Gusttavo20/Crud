
using System;

namespace Crud.UI
{
    partial class FomsCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskcelular = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(112, 85);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(467, 23);
            this.textNome.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(112, 160);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(467, 23);
            this.textEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email do Cliente";
            // 
            // maskcelular
            // 
            this.maskcelular.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskcelular.Location = new System.Drawing.Point(112, 214);
            this.maskcelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskcelular.Mask = "(99) 0000-0000";
            this.maskcelular.Name = "maskcelular";
            this.maskcelular.Size = new System.Drawing.Size(109, 22);
            this.maskcelular.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(470, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskCPF.Location = new System.Drawing.Point(470, 214);
            this.maskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskCPF.Mask = "000-000-000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(109, 22);
            this.maskCPF.TabIndex = 7;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.Lime;
            this.bt_Salvar.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Salvar.Location = new System.Drawing.Point(457, 268);
            this.bt_Salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(122, 41);
            this.bt_Salvar.TabIndex = 8;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Red;
            this.btLimpar.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.Location = new System.Drawing.Point(112, 268);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 41);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);    
            // 
            // FomsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskcelular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FomsCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FomsCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskcelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button btLimpar;
    }
}

