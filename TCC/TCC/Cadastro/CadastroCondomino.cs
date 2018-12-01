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

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = Condominio; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //Verifica se todos os campos foram preenchidos
            if (TxtCPF.Text == "" || TxtNome.Text == "" || TxtSenha.Text == "" || TxtConfirmarSenha.Text == "" || TxtSenha.Text != TxtConfirmarSenha.Text || TxtCNPJCondominio.Text == "")
            {
                LabCadCondo.Visible = true;
                LabCadCondo.Text = "Dados incorretos ou incompletos";
            }
            //Ação se todos os campos forem preenchidos
            else
            {
                //Verifica se o condomínio escolhido existe
                comd.CommandText = "SELECT CNPJ FROM CONDOMINIO WHERE CNPJ = @Cond";
                comd.Parameters.AddWithValue("Cond", TxtCNPJCondominio.Text);

                comd.Connection.Open();
                SqlDataReader ler = comd.ExecuteReader();
                string cnpj = "";
                if (ler.HasRows)
                {
                    ler.Read();
                    cnpj = ler.GetString(0);
                }
                ler.Close();
                comd.Connection.Close();

                if (cnpj == "")
                {
                    LabCadCondo.Visible = true;

                    LabCadCondo.Text = "Não há condomínio cadastrado para esse CNPJ";
                }
                //Se existir um condomínio já cadastrado
                else
                {
                    //Verifica se já existe algum CPF/CNPJ de condômino cadastrado
                    comd.CommandText = "SELECT CPF FROM CONDOMINO WHERE CPF = @Verificar";
                    comd.Parameters.AddWithValue("Verificar", TxtCPF.Text);

                    comd.Connection.Open();
                    SqlDataReader reader = comd.ExecuteReader();
                    string cpf_cnpj = "";
                    if (reader.HasRows)
                    {
                        reader.Read();
                        cpf_cnpj = reader.GetString(0);
                    }
                    reader.Close();
                    comd.Connection.Close();

                    if (cpf_cnpj != "")
                    {
                        LabCadCondo.Visible = true;

                        LabCadCondo.Text = "CPF já cadastrado";
                    }
                    //Se não existir nenhum CPF/CNPJ, ação de cadastrar condômino
                    else
                    {
                        comd.CommandText = "INSERT INTO CONDOMINO (CPF, Senha, Nome, Condominio, Apartamento) VALUES (@CPF, @Senha, @Nome, @Condominio, @Apartamento)";
                        comd.Parameters.AddWithValue("CPF", TxtCPF.Text);
                        comd.Parameters.AddWithValue("Senha", TxtSenha.Text);
                        comd.Parameters.AddWithValue("Nome", TxtNome.Text);
                        comd.Parameters.AddWithValue("Condominio", TxtCNPJCondominio.Text);
                        comd.Parameters.AddWithValue("Apartamento", TxtApt.Text);

                        conex.Open();
                        comd.ExecuteNonQuery();
                        conex.Close();

                        LabCadCondo.Visible = true;
                        LabCadCondo.Text = "Condômino cadastrado com sucesso!";
                    }
                }
            }
        }
    }
}
