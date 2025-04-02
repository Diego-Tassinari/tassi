namespace medicamentos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconBtn2 = new FontAwesome.Sharp.IconButton();
            this.IconBtn1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.IconBtn2);
            this.panel1.Controls.Add(this.IconBtn1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 67);
            this.panel1.TabIndex = 0;
            // 
            // IconBtn2
            // 
            this.IconBtn2.BackColor = System.Drawing.Color.Orange;
            this.IconBtn2.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.IconBtn2.FlatAppearance.BorderSize = 0;
            this.IconBtn2.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.IconBtn2.IconColor = System.Drawing.Color.Black;
            this.IconBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn2.Location = new System.Drawing.Point(75, 9);
            this.IconBtn2.Name = "IconBtn2";
            this.IconBtn2.Size = new System.Drawing.Size(57, 49);
            this.IconBtn2.TabIndex = 1;
            this.IconBtn2.UseVisualStyleBackColor = false;
            this.IconBtn2.Click += new System.EventHandler(this.IconBtn2_Click);
            // 
            // IconBtn1
            // 
            this.IconBtn1.BackColor = System.Drawing.Color.Orange;
            this.IconBtn1.FlatAppearance.BorderSize = 0;
            this.IconBtn1.IconChar = FontAwesome.Sharp.IconChar.Magic;
            this.IconBtn1.IconColor = System.Drawing.Color.Black;
            this.IconBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn1.Location = new System.Drawing.Point(12, 9);
            this.IconBtn1.Name = "IconBtn1";
            this.IconBtn1.Size = new System.Drawing.Size(57, 49);
            this.IconBtn1.TabIndex = 0;
            this.IconBtn1.UseVisualStyleBackColor = false;
            this.IconBtn1.Click += new System.EventHandler(this.IconBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diego Tassinari";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.gerenciarMedicamentosToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar Medicamentos";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // gerenciarMedicamentosToolStripMenuItem
            // 
            this.gerenciarMedicamentosToolStripMenuItem.Name = "gerenciarMedicamentosToolStripMenuItem";
            this.gerenciarMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.gerenciarMedicamentosToolStripMenuItem.Text = "Gerenciar Medicamentos";
            this.gerenciarMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarMedicamentosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::medicamentos.Properties.Resources.image_fundo_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarMedicamentosToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton IconBtn2;
        private FontAwesome.Sharp.IconButton IconBtn1;
    }
}

