using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHamburgueria
{
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        private void bntBebidas_Click(object sender, EventArgs e)
        {

        }

        private void btnLanches_Click(object sender, EventArgs e)
        {
           Menu MN = new Menu();
            MN.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acompanhamentos acom = new Acompanhamentos();
            acom.Show();
            this.Hide();

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btnAcompanhamentos.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            btnAcompanhamentos.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnAcompanhamentos.BackColor = ColorTranslator.FromHtml("#3E2723");
            btnAcompanhamentos.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void btnLanches_MouseHover(object sender, EventArgs e)
        {
            btnLanches.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            btnLanches.ForeColor = Color.Black;
        }

        private void btnLanches_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnLanches_MouseLeave(object sender, EventArgs e)
        {
            btnLanches.BackColor = ColorTranslator.FromHtml("#3E2723");
            btnLanches.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void bntBebidas_MouseHover(object sender, EventArgs e)
        {
            bntBebidas.BackColor = ColorTranslator.FromHtml("#F5E8C8");
            bntBebidas.ForeColor = Color.Black;
        }

        private void bntBebidas_MouseLeave(object sender, EventArgs e)
        {
            bntBebidas.BackColor = ColorTranslator.FromHtml("#3E2723");
            bntBebidas.ForeColor = ColorTranslator.FromHtml("#F5E8C8");
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            Pedido pd = new Pedido();
            pd.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sair == DialogResult.No)
            {
                Bebidas b = new Bebidas();
                b.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioLogin fl = new FuncionarioLogin();
            fl.Show();
            this.Hide();
        }
    }
}
