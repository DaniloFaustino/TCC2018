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
    public partial class RegistrarPagamentos : Form
    {
        public string Adm { get; set; }
        public RegistrarPagamentos(string adm)
        {
            InitializeComponent();
            this.Adm = adm; 
        }

        private void ComboCondominio_DropDown(object sender, EventArgs e)
        {
            //Código tirado da internet
            //criar um DataTable
            DataTable dtTabelas = new DataTable();

            //definir a string de conexao
            String strConn = @"Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;";

            //define a conexao
            SqlConnection conn = new SqlConnection(strConn);

            //Cria o comando 
            string comando = String.Format("select Nome, CNPJ from Condominio where CNPJ IN (Select Condominio from AdmCondominio where CPF_CNPJ = {0})", Adm);

            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter(comando, conn);




            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            ComboCondominio.DataSource = dtTabelas;
            ComboCondominio.DisplayMember = "Nome";
            ComboCondominio.ValueMember = "CNPJ";
        }

        private void ComboCondomino_DropDown(object sender, EventArgs e)
        {
            // criar um DataTable
            DataTable dtTabelas = new DataTable();

            //definir a string de conexao
            String strConn = @"Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;";

            //define a conexao
            SqlConnection conn = new SqlConnection(strConn);

            //Cria o comando 
            string comando = String.Format("select CPF, Apartamento from Condomino where Condominio = {0}", ComboCondominio.SelectedValue);


            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter(comando, conn);

            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            ComboCondomino.DataSource = dtTabelas;
            ComboCondomino.DisplayMember = "Apartamento";
            ComboCondomino.ValueMember = "CPF";
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "SELECT Valor FROM Debito WHERE CPF_Condomino = @Condomino AND Mes = @Mes AND Situacao = @Situ";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Mes", ComboMes.Text);
            comd.Parameters.AddWithValue("Situ", 1);

            comd.Connection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            decimal valor = 0;
            if (reader.HasRows)
            {
                reader.Read();
                valor = reader.GetDecimal(0);
            }
            reader.Close();
            comd.Connection.Close();

            if (valor == 0)
            {
                LabCadRegistro.Visible = true;
                LabCadRegistro.Text = "Nenhum débito encontrado";
                LabMostrarValor.Text = "O Valor é:";
            }
            else
            {
                LabMostrarValor.Text = String.Format("O Valor é: {0}", valor); 
            }

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "UPDATE DEBITO SET Situacao = @Att WHERE CPF_Condomino = @Condomino";
            comd.Parameters.AddWithValue("Att", 2);
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            
            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

            LabCadRegistro.Visible = true;
            LabCadRegistro.Text = "Atualizado!"; 
        }
    }
}
