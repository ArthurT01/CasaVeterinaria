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

namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        private void login()
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = dbhospital; Uid = senai; Pwd = 1234");
                strSQL = "SELECT * FROM t_veterinarios WHERE login = @login AND senha = @senha";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@login", txtLogin.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    string nome = " ";
                    int codV = 0;
                    while (dr.Read())
                    {                      
                        nome = Convert.ToString(dr["nome_veterinario"]);
                        codV = Convert.ToInt32(dr["codigo_veterinario"]);

                    }
                    Frm_PrincipalDoVeterinario Menu = new Frm_PrincipalDoVeterinario(nome,codV);
                    Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha ou Login de usuário incorreto ou inexistênte");
                }

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void chkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "Digite sua senha")
            {
                if (chkExibirSenha.Checked)
                {
                    txtSenha.PasswordChar = default;
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void picSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
