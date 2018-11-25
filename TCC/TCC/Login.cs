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
    public partial class Login : Form
    {
        public string Usuario { get; set; }
        public bool ClicouBotaoLogar { get; set; }
        
        public bool ClicouCadastrar { get; set; }
        public bool LogouAdm { get; set; }
        public bool LogouCondomino { get; set; }

        

        public Login()
        {
            InitializeComponent();

        }

        //Ação caso a opção entrar seja escolhida 
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = Condominio; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //Verifica se todos os campos foram preenchidos
            if (TxtUser.Text == "" || TxtSenha.Text == "")
            {
                LabErro.Visible = true; 
                TxtUser.Text = "";
                TxtSenha.Text = "";
            }
            //Caso todos os campos forem preenchidos 
            else
            {
                //Verifica se as informações batem com um cadastro já existente de admnistrador 
                comd.CommandText = "SELECT CPF_CNPJ FROM ADMINISTRACAO WHERE CPF_CNPJ = @User AND SENHA = @Senha";
                comd.Parameters.AddWithValue("User", TxtUser.Text);
                comd.Parameters.AddWithValue("Senha", TxtSenha.Text);

                comd.Connection.Open();
                SqlDataReader reader = comd.ExecuteReader();
                string adm = "";
                if (reader.HasRows)
                {
                    reader.Read();
                    adm = reader.GetString(0);
                }
                reader.Close();
                comd.Connection.Close();

                //Verifica se as informações batem com um cadastro já existente de condômino
                comd.CommandText = "SELECT CPF FROM CONDOMINO WHERE CPF = @Cpf AND SENHA = @Senha";
                comd.Parameters.RemoveAt("Senha");
                comd.Parameters.AddWithValue("Cpf", TxtUser.Text);
                comd.Parameters.AddWithValue("Senha", TxtSenha.Text);

                comd.Connection.Open();
                reader = comd.ExecuteReader();
                string condo = "";
                if (reader.HasRows)
                {
                    reader.Read();
                    condo = reader.GetString(0);
                }
                reader.Close();
                comd.Connection.Close();

                //Caso não exista nem admnistrador nem condômino
                if (adm == "" && condo == "")
                {
                    LabErro.Visible = true; 
                    TxtUser.Text = "";
                    TxtSenha.Text = "";
                }
                //Caso exista administrador
                else if (adm != "" && condo == "")
                {
                    this.Usuario = TxtUser.Text;
                    ClicouBotaoLogar = true;
                    ClicouCadastrar = false;
                    LogouAdm = true;
                    LogouCondomino = false; 
                    this.Close();
                }
                //Caso exista condômino
                else if (adm == "" && condo != "")
                {
                    this.Usuario = TxtUser.Text;
                    ClicouBotaoLogar = true;
                    ClicouCadastrar = false;
                    LogouAdm = false;
                    LogouCondomino = true;
                    this.Close();
                }

            }

        }

        //Ação caso a opção cadastrar seja selecionada
        private void LinkCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroOpcoes cadOp = new CadastroOpcoes();
            cadOp.ShowDialog(); 
        }
    }
}
