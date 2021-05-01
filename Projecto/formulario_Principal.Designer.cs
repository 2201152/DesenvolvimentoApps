namespace Projecto
{
    partial class formulario_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVendasDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeEscolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAnimadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1ToolStripMenuItem,
            this.gestãoDeVendasDeProdutosToolStripMenuItem,
            this.gestãoDeEventosToolStripMenuItem,
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem,
            this.gestãoDeEscolasToolStripMenuItem,
            this.gestãoDeAnimadoresToolStripMenuItem,
            this.open2ToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // open1ToolStripMenuItem
            // 
            this.open1ToolStripMenuItem.Name = "open1ToolStripMenuItem";
            this.open1ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.open1ToolStripMenuItem.Text = "Gestão de Clientes e seus Filhos";
            this.open1ToolStripMenuItem.Click += new System.EventHandler(this.open1ToolStripMenuItem_Click);
            // 
            // open2ToolStripMenuItem
            // 
            this.open2ToolStripMenuItem.Name = "open2ToolStripMenuItem";
            this.open2ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.open2ToolStripMenuItem.Text = "Open 2";
            this.open2ToolStripMenuItem.Click += new System.EventHandler(this.open2ToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gestãoDeVendasDeProdutosToolStripMenuItem
            // 
            this.gestãoDeVendasDeProdutosToolStripMenuItem.Name = "gestãoDeVendasDeProdutosToolStripMenuItem";
            this.gestãoDeVendasDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.gestãoDeVendasDeProdutosToolStripMenuItem.Text = "Gestão de Vendas de Produtos";
            this.gestãoDeVendasDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeVendasDeProdutosToolStripMenuItem_Click);
            // 
            // gestãoDeEventosToolStripMenuItem
            // 
            this.gestãoDeEventosToolStripMenuItem.Name = "gestãoDeEventosToolStripMenuItem";
            this.gestãoDeEventosToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.gestãoDeEventosToolStripMenuItem.Text = "Gestão de Eventos";
            this.gestãoDeEventosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeEventosToolStripMenuItem_Click);
            // 
            // gestãoDeProdutosVendidosPelaLojaToolStripMenuItem
            // 
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem.Name = "gestãoDeProdutosVendidosPelaLojaToolStripMenuItem";
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem.Text = "Gestão de Produtos Vendidos pela Loja";
            this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProdutosVendidosPelaLojaToolStripMenuItem_Click);
            // 
            // gestãoDeEscolasToolStripMenuItem
            // 
            this.gestãoDeEscolasToolStripMenuItem.Name = "gestãoDeEscolasToolStripMenuItem";
            this.gestãoDeEscolasToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.gestãoDeEscolasToolStripMenuItem.Text = "Gestão de Escolas";
            this.gestãoDeEscolasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeEscolasToolStripMenuItem_Click);
            // 
            // gestãoDeAnimadoresToolStripMenuItem
            // 
            this.gestãoDeAnimadoresToolStripMenuItem.Name = "gestãoDeAnimadoresToolStripMenuItem";
            this.gestãoDeAnimadoresToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.gestãoDeAnimadoresToolStripMenuItem.Text = "Gestão de Animadores";
            this.gestãoDeAnimadoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAnimadoresToolStripMenuItem_Click);
            // 
            // formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formulario_Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeVendasDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProdutosVendidosPelaLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeEscolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAnimadoresToolStripMenuItem;
    }
}

