namespace medicamentos
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód.Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arquivo";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(34, 84);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(320, 22);
            this.txtCaminho.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Caminho";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(466, 84);
            this.txtCodBarras.MaxLength = 13;
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(153, 22);
            this.txtCodBarras.TabIndex = 5;
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Orange;
            this.btnSelecionar.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(466, 128);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(153, 30);
            this.btnSelecionar.TabIndex = 6;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(34, 209);
            this.txtArquivo.Multiline = true;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(585, 187);
            this.txtArquivo.TabIndex = 7;
            this.txtArquivo.TextChanged += new System.EventHandler(this.txtArquivo_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtArquivo;
    }
}