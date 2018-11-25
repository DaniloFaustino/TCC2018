using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CadastroCondomino : Form
    {
        public CadastroCondomino()
        {
            InitializeComponent();
        }

        private void CadastroCondomino_Load(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = Condominio; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //criar um DataTable
            DataTable dtTabelas = new DataTable();

            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter("select cnpj from condominio", conex);

            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            ComboCondo.DataSource = dtTabelas;
            ComboCondo.DisplayMember = "campo";
            ComboCondo.ValueMember = "campo";

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = Condominio; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //Verifica se todos os campos foram preenchidos
            if (TxtCPF.Text == "" || TxtNome.Text == "" || TxtSenha.Text == "" || TxtConfirmarSenha.Text == "" || TxtSenha.Text != TxtConfirmarSenha.Text)
            {
                LabCadCondo.Visible = true;
                LabCadCondo.Text = "Dados incorretos ou incompletos";
            }
            //Ação se todos os campos forem preenchidos
            else
            {
                //Verifica se já existe algum CNPJ de condomínio cadastrado
                comd.CommandText = "SELECT CPF FROM CONDOMiNO WHERE CPF = @Teste";
                comd.Parameters.AddWithValue("Teste", TxtCPF.Text);

                comd.Connection.Open();
                SqlDataReader reader = comd.ExecuteReader();
                string cpf = "";
                if (reader.HasRows)
                {
                    reader.Read();
                    cpf = reader.GetString(0);
                }
                reader.Close();
                comd.Connection.Close();

                if (cpf != "")
                {
                    LabCadCondo.Visible = true;

                    LabCadCondo.Text = "CPFJ já cadastrado";
                }
                //Se não existir nenhum CNPJ, ação de cadastrar condomínio
                else
                {
                    comd.CommandText = "INSERT INTO CONDOMINO (CPF, Senha, Nome, Condominio, Apartamento) VALUES (@CPF, @Senha, @Nome, @Condominio, @Apartamento)";
                    comd.Parameters.AddWithValue("CPF", TxtCPF.Text);
                    comd.Parameters.AddWithValue("Nome", TxtNome.Text);
                    comd.Parameters.AddWithValue("Senha", TxtSenha.Text);
                    comd.Parameters.AddWithValue("Condominio", ComboCondo.Text);
                    comd.Parameters.AddWithValue("Apartamento", TxtApt.Text);

                    conex.Open();
                    comd.ExecuteNonQuery();
                    conex.Close();

                    LabCadCondo.Visible = true;
                    LabCadCondo.Text = "Condomínio cadastrado com sucesso!";
                }
            }
        }
    }
}
