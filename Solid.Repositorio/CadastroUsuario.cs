using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Repositorio
{
    public class CadastroUsuario
    {

        public void Inserir(string Nome, string CPF, string Senha)
        {
            string CONFIG = "server =127.0.0.1;userid=root;database=sistema";
            MySqlConnection Conexao = new MySqlConnection(CONFIG);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = Conexao;
            Conexao.Open();
            Query.CommandText = "INSERT INTO login(Nome, Senha) VALUES(@nome, @senha)";
            Query.Parameters.AddWithValue("@nome", Nome);
            Query.Parameters.AddWithValue("@senha", Senha);
            Query.ExecuteNonQuery();
            Conexao.Close();
        }

    }
}
