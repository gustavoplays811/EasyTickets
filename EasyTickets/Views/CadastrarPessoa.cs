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
    public partial class CadastrarPessoa : Form
    {
        public CadastrarPessoa()
        {
            InitializeComponent();
            Classes.Cliente cliente = new Classes.Cliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Classes.Cliente cliente = new Classes.Cliente();
            
            cliente.Nome = txbNome.Text;
            cliente.Email = txbEmail.Text;
            cliente.Documento = txbDocumento.Text;
            cliente.Idade = txbIdade.Text;
            cliente.Endereco = txbEndereco.Text;
            cliente.Telefone = txbTelefone.Text;
            cliente.Senha = txbSenha.Text;
            if (cliente.Cadastrar() == true)
            {
                MessageBox.Show("Cadastro Realizado Com Sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
