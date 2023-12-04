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
using EasyEncryption;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EasyTickets.Classes
{
    public class Eventos
    {
        public int Id { get; set; }
        public string Nome_Show { get; set; }
        public DateTime DataShow { get; set; }
        public string Local { get; set; }
        public double Preco { get; set; }
        public int QtdIngressos { get; set; }

        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_show, data_show, local, preco FROM evento";

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
            string comando = "INSERT INTO evento (Nome_Show, preco, local) " +
                "VALUES (@nome_Show, @preco, @local)";
            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_Show", Nome_Show);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@local", Local);
            cmd.Prepare();
            try
            {
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
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Apagar()
        {




            string comando = "DELETE FROM evento WHERE id = @id";

            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
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
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
        public bool Modificar()
        {
            string comando = "UPDATE evento SET nome_show = @nome_show , " +
                "data_show = @data, preco = @preco, local = @local WHERE id = @id";

            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
           
            cmd.Parameters.AddWithValue("@nome_show", Nome_Show);
            cmd.Parameters.AddWithValue ("@data", DataShow);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@local", Local);
            cmd.Parameters.AddWithValue("@id", Id);


            cmd.Prepare();
            try
            {
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
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}


        
     



