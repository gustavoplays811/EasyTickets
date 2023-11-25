using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTickets.Views
{
    public partial class abertura : Form
    {
        public abertura()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Views.abertura janela = new Views.abertura();
            janela.Show();
        }

        private void btnCentral_Click(object sender, EventArgs e)
        {

        }

        private void btnVip_Click(object sender, EventArgs e)
        {

        }

        private void btnLateral_Click(object sender, EventArgs e)
        {
            Views.ControleDeVendas janela = new Views.ControleDeVendas();
            janela.Show();
        }
    }
}
