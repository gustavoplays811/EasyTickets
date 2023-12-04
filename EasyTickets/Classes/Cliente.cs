using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTickets.Classes
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Idade { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }


        public DataTable Logar()
        {
            string comando = "SELECT id, Idade, Nome, Email, Senha, Telefone, Endereco, Documento" +
                " FROM Cliente WHERE email = @email AND senha = @senha";

            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@email", Email);
            var hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

           
        }
        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome, email, telefone FROM Cliente";

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
            string comando = "INSERT INTO cliente (nome,idade,email,telefone,endereco,documento) " +
                "VALUES (@nome,@idade,@email,@telefone,@endereco,@documento)";
            Banco.ConexaoBD conexaoBD = new Banco.ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@idade", Idade);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@endereco", Endereco);
            cmd.Parameters.AddWithValue("@documento", Documento);
            
            // Obter o hash:
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
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
