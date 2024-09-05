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
    public partial class Frm_CadastarExames : Form
    {     
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        int CodA;

        public Frm_CadastarExames(int codAnimal, string nomeUser)
        {
            InitializeComponent();
            CodA = codAnimal;
            lblUser.Text = "Usuário: "+nomeUser;
        }

        private void btnCadastrarExame_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = dbhospital; Uid = senai; Pwd = 1234");
                strSQL = "INSERT INTO t_exames (nome_exame, fk_codigo_animal) VALUES (@nomeExames, @fk_codigo_animal) ";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nomeExames", txtNomeExame.Text);
                comando.Parameters.AddWithValue("@fk_codigo_animal", CodA);
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
