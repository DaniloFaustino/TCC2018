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

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = Condominio; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            if (TxtUser.Text == "" || TxtSenha.Text == "")
            {
                LabErro.Visible = true; 
                TxtUser.Text = "";
                TxtSenha.Text = "";
            }
            else
            {
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

                if (adm == "" && condo == "")
                {
                    LabErro.Text = "Informações Inválidas";
                    TxtUser.Text = "";
                    TxtSenha.Text = "";
                }
                else if (adm != "" && condo == "")
                {
                    this.Usuario = TxtUser.Text;
                    ClicouBotaoLogar = true;
                    ClicouCadastrar = false;
                    LogouAdm = true;
                    LogouCondomino = false; 
                    this.Close();
                }
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

        private void LinkCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroOpcoes cadOp = new CadastroOpcoes();
            cadOp.ShowDialog(); 
        }
    }
}
