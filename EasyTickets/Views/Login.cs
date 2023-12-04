using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTickets
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Views.Abertura janela = new Views.Abertura();
            janela.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Views.CadastrarPessoa janela = new Views.CadastrarPessoa();
            janela.Show();
        }
    }
}
