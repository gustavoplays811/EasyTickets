using EasyTickets.Classes;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTickets.Views
{
    public partial class EventosComprados : Form
    {
        int idSelecionado = 0;
        public EventosComprados()
        {
            Eventos evento = new Eventos();
            InitializeComponent();
            dgvAdicionarShow.DataSource = evento.ListarTudo();


        }

        private void EventosComprados_Load(object sender, EventArgs e)
        {

        }

        private void lblEdiPreco_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarComp_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
          
        }

        private void lblSelecioneComp_Click(object sender, EventArgs e)
        {

        }

        private void txbEmailCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Eventos evento = new Classes.Eventos();
            // Obter os valores dos campos:
            evento.Nome_Show = txbNomeShow.Text;
            evento.DataShow = DateTime.Parse(txbDataShow.Text);
            evento.Local = txbLocalShow.Text;
            evento.Preco = int.Parse(txbPrecoShow.Text);

            if (evento.Cadastrar() == true)
            {
                MessageBox.Show("Evento cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeShow.Clear();
                txbDataShow.Clear();
                txbLocalShow.Clear();
                txbPrecoShow.Clear();
                // Atualizar o dgv:
                dgvAdicionarShow.DataSource = evento.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar evento!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Eventos evento = new Classes.Eventos();

            // Obter os valores dos txbs:

            evento.Nome_Show = txbEditNomeShow.Text;
            evento.DataShow = DateTime.Parse(txbEditDataShow.Text);
            evento.Preco = double.Parse(txbEditPrecoShow.Text);
            evento.Local = txbEditLocalShow.Text;
            evento.Id = idSelecionado;

            // Editar:
            if (evento.Modificar() == true)
            {
                MessageBox.Show("Evento modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dgvAdicionarShow.DataSource = evento.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao modificar Evento!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Eventos evento = new Classes.Eventos();
            evento.Id = idSelecionado;

            // Apagar:
            var r = MessageBox.Show("Tem certeza que deseaja remover?", "ATENÇÃO!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //Apagar:
                if (evento.Apagar() == true)
                {
                    MessageBox.Show("Evento removido", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAdicionarShow.DataSource = evento.ListarTudo();

                    txbNomeShow.Clear();
                    txbDataShow.Clear();
                    txbPrecoShow.Clear();
                    txbLocalShow.Text = "Selecione um Evento para apagar.";
                }
            }
        }

        private void dgvAdicionarShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvAdicionarShow.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvAdicionarShow.Rows[linhaSelecionada];

            // Preencher os campos:
            txbEditNomeShow.Text = linha.Cells[1].Value.ToString();
            txbEditDataShow.Text = linha.Cells[2].Value.ToString();
            txbEditLocalShow.Text = linha.Cells[3].Value.ToString();
            txbEditPrecoShow.Text = linha.Cells[4].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }
    }
}
