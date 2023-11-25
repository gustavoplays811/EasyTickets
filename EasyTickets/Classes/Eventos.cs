using MySqlConnector;
using EasyTickets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EasyTickets.Classes
{
    internal class Eventos
    {
        public int Id { get; set; }
        public string NomeShow { get; set; }
        public string DataShow { get; set; }
        public string Local { get; set; }
        public double preco { get; set; }

        public DataTable ListarTudo()
        {
            string comando = "SELECT Id, NomeShow, Local, Preco FROM evento";

            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }

}
