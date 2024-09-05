using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    public partial class Frm_InformaçõesAnimal : Form
    {
        public string CodigoAnimal { get; set; }
        public string CodigoVeterinario { get; set; }

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dataReader;
        int CodA;
        string nomeU;


        public Frm_InformaçõesAnimal(string codA, string nomeA, string NomeUser)
        {
            InitializeComponent();
            CodA = int.Parse(codA);
            nomeU = NomeUser;
            lblNomeAnimal.Text = "Paciente: "+nomeA;
            lblUser.Text = "Usuário: " + NomeUser;
            this.Load += new System.EventHandler(this.VisualizarForm_Load);
        }

        private void VisualizarForm_Load(object sender, EventArgs e)
        {
            //buscaNomeAnimal();
            buscaExames();
        }

        private void btnCadastrarExames_Click(object sender, EventArgs e)
        {

            Frm_CadastarExames cadastrarExames = new Frm_CadastarExames(CodA, nomeU);
            cadastrarExames.Show();
        }

        private void buscaExames()
        {
            conexao = new MySqlConnection("Server = localhost; Database = dbhospital; Uid = senai; Pwd = 1234");
            comando = new MySqlCommand($"SELECT codigo_exame, nome_exame FROM t_exames WHERE fk_codigo_animal = {CodA}", conexao);
            conexao.Open();
            dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {
                dtInformaçõesAnimal.Rows.Add(
                    dataReader[0].ToString(),
                    dataReader[1].ToString()
                );
            }
            dataReader.Close();
            conexao.Close();
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_InformaçõesAnimal_Load(object sender, EventArgs e)
        {

        }
    }

    
}
