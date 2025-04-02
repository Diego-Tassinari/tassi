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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool ValidarDiretorio()
        {
            string diretorio = txtCaminho.Text;
            string NomeArquivo = txtCodBarras.Text;
            //validar o preeenchimento dos campos
            if (string.IsNullOrEmpty(diretorio) || string.IsNullOrEmpty(NomeArquivo))
            {
                MessageBox.Show("Por Favor selecione um diretório" + "informe um nome de arquivo");
                return false;
            }
            //VAlidar se o diretorio é valido  para utilizar o directory é preciso importar a biblioteca using System.IO;
            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("O diretorio especificado" + "Não existe ");
                return false;
            }
            //Se chegou aqui está ok
            return true;
        }
        string GetDiretorioCompleto()
        {
            return Path.Combine(txtCaminho.Text, txtCodBarras.Text + ".txt");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
            if (!ValidarDiretorio())
                return;
            string caminhocompleto = GetDiretorioCompleto();
            if (File.Exists(caminhocompleto))
            {
                //ler o arquivo e apresentar o conteudo no texBox
                txtArquivo.Text = File.ReadAllText(caminhocompleto);
                MessageBox.Show("Conteudo carregado com sucesso");
            }
            else
            {
                MessageBox.Show("O arquivo não existe");
            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
