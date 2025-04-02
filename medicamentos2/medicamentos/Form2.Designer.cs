using System;
using System.Windows.Forms;

namespace medicamentos
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrincipio = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(167, 93);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(60, 16);
            this.C.TabIndex = 2;
            this.C.Text = "Caminho";
            this.C.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preço";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Principio Ativo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cód.Barras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quantidade";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(15, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(14, 112);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(130, 22);
            this.txtCnpj.TabIndex = 11;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Validating += new System.ComponentModel.CancelEventHandler(this.txtCnpj_Validating);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(170, 113);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(215, 22);
            this.txtCaminho.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 207);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 22);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 274);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(81, 22);
            this.txtPreco.TabIndex = 14;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            this.txtPreco.Validating += new System.ComponentModel.CancelEventHandler(this.txtPreco_Validating);
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(144, 274);
            this.txtCodBarras.MaxLength = 13;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(129, 22);
            this.txtCodBarras.TabIndex = 15;
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            this.txtCodBarras.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodBarras_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Medicamento";
            // 
            // txtPrincipio
            // 
            this.txtPrincipio.Location = new System.Drawing.Point(464, 58);
            this.txtPrincipio.Name = "txtPrincipio";
            this.txtPrincipio.Size = new System.Drawing.Size(129, 22);
            this.txtPrincipio.TabIndex = 17;
            this.txtPrincipio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrincipio_Validating);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(464, 132);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(81, 22);
            this.txtQuantidade.TabIndex = 18;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantidade_Validating);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Orange;
            this.btnSalvar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(367, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 40);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Orange;
            this.btnCancelar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(589, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(475, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 308);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPrincipio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void folderBrowserDialog(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrincipio;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}