using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    public partial class Frm_PrincipalDoVeterinario : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dataReader;
        int codV = 0;
        string nomeU = "";

        public Frm_PrincipalDoVeterinario()
        {
            InitializeComponent();
        }

        public Frm_PrincipalDoVeterinario(string nomeUser, int CodVet)
        {
            InitializeComponent();
            codV = CodVet;
            nomeU = nomeUser;
            ListarTabela();
            lblUser.Text = "User: " + nomeUser;
            
        }

        public void ListarTabela()
        {
            //int i = 0;
            dtListaPacientes.Rows.Clear();
            conexao = new MySqlConnection("Server = localhost; Database = dbhospital; Uid = senai; Pwd = 1234");
            comando = new MySqlCommand($"SELECT codigo_animal,nome_animal FROM t_animais WHERE fk_codigo_veterinario = {codV}", conexao);
            conexao.Open();
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                dtListaPacientes.Rows.Add(
                    dataReader[0].ToString(),
                    dataReader[1].ToString()
                );
            }
            dataReader.Close();
            conexao.Close();
       
                
        }

        private void dtListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                string colName = dtListaPacientes.Columns[e.ColumnIndex].Name;

                if (colName == "colExames")
                {
                    try
                    {
                        string codigo = dtListaPacientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string nome = dtListaPacientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                        

                        Frm_InformaçõesAnimal visualizarForm = new Frm_InformaçõesAnimal(codigo, nome, nomeU);
                        {
                            //Codigo = codigo;
                            //Nome = nome,
                            //Idade = idade,
                            //Telefone = telefone,
                            //Cpf = cpf
                        };

                        visualizarForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao visualizar registro: " + ex.Message);
                    }
                }
                else if (colName == "colExcluir")
                {
                    if (MessageBox.Show("Quer mesmo excluir?", "Deletar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            conexao.Open();

                            string codigo = dtListaPacientes.Rows[e.RowIndex].Cells[0].Value.ToString();

                            comando = new MySqlCommand("DELETE FROM t_animais WHERE codigo_animal = @codigo", conexao);
                            comando.Parameters.AddWithValue("@codigo", codigo);

                            comando.ExecuteNonQuery();
                            conexao.Close();

                            ListarTabela();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir registro: " + ex.Message);
                        }
                        finally
                        {
                            if (conexao.State == ConnectionState.Open)
                                conexao.Close();
                        }
                    }
                }

        }

        private void btnCadastrarAnimal_Click(object sender, EventArgs e)
        {
            Frm_CadastrarAnimal frmCadastrarAnimal = new Frm_CadastrarAnimal(codV, nomeU);
            frmCadastrarAnimal.Show();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
