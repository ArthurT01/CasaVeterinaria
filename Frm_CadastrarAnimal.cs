using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    public partial class Frm_CadastrarAnimal : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        int CodV;

        public Frm_CadastrarAnimal(int codVet, string nomeUser)
        {
            InitializeComponent();
            CodV = codVet;
            lblUser.Text = "Usuário: "+nomeUser;    
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = dbhospital; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_animais (nome_animal, fk_codigo_veterinario) VALUES (@nome_animal, @fk_codigo_veterinario) ";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nome_animal", txtNomeAnimal.Text);
                comando.Parameters.AddWithValue("@fk_codigo_veterinario", CodV);
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Efetuado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
