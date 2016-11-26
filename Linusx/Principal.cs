using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Linusx
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            txtSenha.Text = "";
            txtSenha.PasswordChar = '•';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Cadastra CadastraUsuario = new Cadastra();
            this.Hide();
            CadastraUsuario.ShowDialog();
            this.Show();
            Principal principal = new Principal();
            principal.Close();
            button3.Hide();


        }

        private void Principal_Load(object sender, EventArgs e)
        {
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Senha = txtSenha.Text;
            string CONFIG = "server =127.0.0.1;userid=root;database=sistema";
            MySqlConnection Conexao = new MySqlConnection(CONFIG);
            MySqlCommand Query = new MySqlCommand();
            Conexao.Open();
            Query.Connection = Conexao;
            Query.CommandText = "SELECT Nome, Senha FROM login Where Nome = @nome AND Senha = @senha";
            Query.Parameters.AddWithValue("@nome", Nome);
        
            Query.Parameters.AddWithValue("@senha", Senha);
            bool Verifica = Query.ExecuteReader().HasRows;
            if (Verifica == true)
            {
                Controle Controle = new Controle();
                this.Hide();
                Controle.ShowDialog();
            }
            else {
                MessageBox.Show("senha e nome incorretos");
            }
        }
    }
}
