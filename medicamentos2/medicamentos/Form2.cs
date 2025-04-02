using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicamentos
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        string GetDiretorioCompleto()
        {
            return Path.Combine(txtCaminho.Text, txtCodBarras.Text + ".txt");
        }

        bool ValidarDiretorio()
        {
            string diretorio = txtCaminho.Text;
            string NomeArquivo = txtCodBarras.Text;
            //Validar os preenchimentos dos campos
            if (string.IsNullOrEmpty(diretorio) || string.IsNullOrEmpty(NomeArquivo))
            {
                MessageBox.Show("Por Favor selecione um diretório e informe um nome de arquivo");
                return false;
            }
            //Validar se o diretorio é valido  para utilizar o directory é preciso importar a biblioteca using System.IO;
            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("O diretorio em especifico não existe");
                return false;
            }
            //Se chegou aqui está ok!
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private object FolderBrowserDialog;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento de " +
                                "todos os campos obrigatórios.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            DialogResult resultado = folderBrowserDialog3.ShowDialog();
            if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog3.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog3.SelectedPath;
            }
            if (!ValidarDiretorio())
                return;
            string caminhocompleto = GetDiretorioCompleto();
            File.WriteAllText(caminhocompleto, "");
            MessageBox.Show("Arquivo Criado com Sucesso");
            if (File.Exists(caminhocompleto))
                MessageBox.Show("O arquivo já existe");

            if (!ValidarDiretorio())
                return;
            string caminho = GetDiretorioCompleto();
            File.WriteAllText(caminho, "Nome: " + txtNome.Text + Environment.NewLine + "CNPJ: " + txtCnpj.Text + Environment.NewLine + "Código de Barras: " + txtCodBarras.Text + Environment.NewLine
                + "Descrição: " + txtDescricao.Text + Environment.NewLine + "Preço: " + txtPreco.Text + Environment.NewLine + "Principio Ativo: " + txtPrincipio.Text + Environment.NewLine + "Quantidade: " + txtQuantidade.Text);
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCnpj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtNome, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtNome, "");
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtNome, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtNome, "");
            }
        }

        private void txtPrincipio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipio.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtPrincipio, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtPrincipio, "");
            }
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtQuantidade, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtQuantidade, "");
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtDescricao, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtDescricao, "");
            }
        }

        private void txtPreco_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtPreco, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtPreco, "");
            }
        }

        private void txtCodBarras_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodBarras.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtCodBarras, "Preencha o nome do Fabricante");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtCodBarras, "");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            {
                Limpar();
            }
        }
        private void Limpar()
        {
            txtPrincipio.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtCodBarras.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtCaminho.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente descartar as alterações?", "Confirmçao", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }
    }
}


    
   

