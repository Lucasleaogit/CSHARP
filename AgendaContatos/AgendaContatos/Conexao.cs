using MySql.Data.MySqlClient;
using System;

namespace AgendaContatos
{
    public class Conexao
    {
        private static string strConexao =
            "server=localhost;database=Cadastro;uid=root;pwd=acesso123;";

        public static MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(strConexao);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar: " + ex.Message);
            }
        }
    }
}