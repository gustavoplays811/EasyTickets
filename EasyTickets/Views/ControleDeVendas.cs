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
    public partial class ControleDeVendas : Form
    {
        int idSelecionado = 0;
        double preco = 0;
        public ControleDeVendas()
        {
            InitializeComponent();
            Eventos eventos = new Eventos();
            Cliente cliente = new Cliente();
            DgvEventos.DataSource = eventos.ListarTudo();
            dgvUsuarios.DataSource = cliente.ListarTudo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbPagRec_Enter(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Eventos eventos = new Classes.Eventos();
            eventos.Id = idSelecionado;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            var r = MessageBox.Show("Tem certeza que deseja comprar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.EventosDispo compra = new Classes.EventosDispo();
                compra.Id_Cliente = int.Parse(txbIdCliente.Text);
                compra.Id_Show = idSelecionado;
                compra.QtdIngressos = int.Parse(cmbQtdIngressos.Text);
                if (compra.Cadastrar() == true)
                {
                    MessageBox.Show("Compra realizada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar:
                    txbNome.Clear();
                    txbData.Clear();
                    txbIdCliente.Clear();
                    txbNomeUsuario.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao comprar!", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grbEdiCompra_Enter(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ControleDeVendas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbQtdIngressos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = preco * double.Parse(cmbQtdIngressos.Text);
            lblPag.Text = "R$" + total.ToString();
        }

        private void DgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAddCompra.Enabled = true;
            

            int linhaSelecionada = DgvEventos.CurrentCell.RowIndex;
            var linha = DgvEventos.Rows[linhaSelecionada];
            preco = double.Parse(linha.Cells[4].Value.ToString());

            txbData.Text = linha.Cells[2].Value.ToString();
            txbNome.Text = linha.Cells[1].Value.ToString();
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grbUsuarios.Enabled = true;

            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            txbNomeUsuario.Text = linha.Cells[1].Value.ToString();
            txbEmail.Text = linha.Cells[3].Value.ToString();
            txbIdCliente.Text = linha.Cells[0].Value.ToString();
            idSelecionado = (int)linha.Cells[0].Value;
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbAddCompra_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
    

