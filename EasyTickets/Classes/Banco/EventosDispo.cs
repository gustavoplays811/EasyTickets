using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace EasyTickets.Classes
{
    public class EventosDispo
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Show { get; set; }
        public int QtdIngressos { get; set; }

        public DataTable ListarTudo()
        {
            string comando = "SELECT nomeshow, data_show, id_cliente, qtdingressos FROM compra";

            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO compra (id_show,id_cliente,qtdingressos) " +
                "VALUES (@id_show,@id_cliente,@qtdingressos)";
            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_cliente", Id_Cliente);
            cmd.Parameters.AddWithValue("@id_show", Id_Show);
            cmd.Parameters.AddWithValue("@qtdingressos", QtdIngressos);
            //try
            //{
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            //}
            //catch
            //{
            //    conexaoBD.Desconectar(con);
            //    return false;
            //}


        }
    }
}
