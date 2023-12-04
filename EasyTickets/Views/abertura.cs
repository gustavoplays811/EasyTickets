using EasyTickets.Classes;
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
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
            Eventos eventos = new Eventos();
            DGVEventosViews.DataSource = eventos.ListarTudo();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Views.Abertura janela = new Views.Abertura();
            janela.Show();
        }

        private void btnCentral_Click(object sender, EventArgs e)
        {

            Views.ControleDeVendas janela = new Views.ControleDeVendas();
            janela.Show();
        }

        private void btnVip_Click(object sender, EventArgs e)
        {

            Views.ControleDeVendas janela = new Views.ControleDeVendas();
            janela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Views.EventosComprados janela = new Views.EventosComprados();
            janela.Show();
        }

        private void DGVEventosViews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Abertura_Activated(object sender, EventArgs e)
        {

        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            
        }

        private void Abertura_Load(object sender, EventArgs e)
        {

        }
    }
}
