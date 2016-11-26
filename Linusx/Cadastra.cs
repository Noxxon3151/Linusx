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
using Solid.Repositorio;

namespace Linusx
{
    public partial class Cadastra : Form


    {
        public Cadastra()
        {
            InitializeComponent();

            txtSenha.Text = "";
            txtSenha.PasswordChar = '•';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastra_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Senha = txtSenha.Text;
            var Cadastro = new CadastroUsuario();
            Cadastro.Inserir(Nome, "", Senha);
            MessageBox.Show("Cadastro Efetuado Com Sucesso!");
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
