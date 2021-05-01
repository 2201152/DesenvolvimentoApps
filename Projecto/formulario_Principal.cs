using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto
{
    public partial class formulario_Principal : Form
    {
        public formulario_Principal()
        {
            InitializeComponent();
        }
        //clicar menu strip para abrir form GestaoClienteseFilhos
        private void open1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoClienteseFilhos")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoClienteseFilhos f2 = new GestaoClienteseFilhos();
                f2.MdiParent = this;
                f2.Show();
            }

        }

        


        //clicar menu strip para abrir form gestãoDeVendasDeProdutos
        private void gestãoDeVendasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoDeVendasProdutos")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoVendasProdutos f3 = new GestaoVendasProdutos();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        //clicar menu strip para abrir form Gestao de Eventos
        private void gestãoDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoEventos")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoEventos f4 = new GestaoEventos();
                f4.MdiParent = this;
                f4.Show();
            }
        }

        //clicar menu strip para abrir form gestãoDeProdutosVendidosPelaLoja
        private void gestãoDeProdutosVendidosPelaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoProdutosVendidos")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoProdutosVendidos f5 = new GestaoProdutosVendidos();
                f5.MdiParent = this;
                f5.Show();
            }
        }
        //clicar menu strip para abrir formgestãoDeEscolas
        private void gestãoDeEscolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoEscolas")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoEscolas f6 = new GestaoEscolas();
                f6.MdiParent = this;
                f6.Show();
            }
        }

        //clicar menu strip para abrir form gestãoDeAnimadores
        private void gestãoDeAnimadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestaoAnimadores")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (IsOpen == false)
            {
                GestaoAnimadores f7 = new GestaoAnimadores();
                f7.MdiParent = this;
                f7.Show();
            }
        }



        //Abrir vários
        private void open2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        //Menu Fechar
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }

            }
        }
    }
}
