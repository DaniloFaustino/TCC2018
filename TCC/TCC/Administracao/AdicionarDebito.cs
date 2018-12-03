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
    public partial class AdicionarDebito : Form
    {
        public string Adm { get; set; }

        public AdicionarDebito(string adm)
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

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //Pega o valor do condomínio
            comd.CommandText = "SELECT Valor FROM Condominio WHERE CNPJ = @CNPJ";
            comd.Parameters.AddWithValue("CNPJ", ComboCondominio.SelectedValue);
            

            comd.Connection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            decimal adm = 0;
            if (reader.HasRows)
            {
                reader.Read();
                adm = reader.GetDecimal(0);
            }
            reader.Close();
            comd.Connection.Close();
            decimal valor = adm;

            //QUantas vezes naquele mês o condômino teve a multa 1 (Barulho)
            comd.CommandText = "SELECT COUNT (Id_Adicional) FROM Adicional WHERE Condomino = @Condomino AND Codigo = '1' AND Mes = @Mes ";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Mes", ComboMes.Text);


            comd.Connection.Open();
            reader = comd.ExecuteReader();
            int multa1 = 0;
            if (reader.HasRows)
            {
                reader.Read();
                multa1 = reader.GetInt32(0);
            }
            reader.Close();
            comd.Connection.Close();

            //QUantas vezes naquele mês o condômino teve a multa 2 (Salão de Festas)
            comd.CommandText = "SELECT COUNT (Id_Adicional) FROM Adicional WHERE Condomino = @Condomino AND Codigo = '2' AND Mes = @Mes";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Mes", ComboMes.Text);


            comd.Connection.Open();
            reader = comd.ExecuteReader();
            int multa2 = 0;
            if (reader.HasRows)
            {
                reader.Read(); 
                multa2 = reader.GetInt32(0);
            }
            reader.Close();
            comd.Connection.Close();

            //QUantas vezes naquele mês o condômino teve a multa 3 (Churrasqueira)
            comd.CommandText = "SELECT COUNT (Id_Adicional) FROM Adicional WHERE Condomino = @Condomino AND Codigo = '3' AND Mes = @Mes";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Mes", ComboMes.Text);


            comd.Connection.Open();
            reader = comd.ExecuteReader();
            int multa3 = 0;
            if (reader.HasRows)
            {
                reader.Read(); 
                multa3 = reader.GetInt32(0);
            }
            reader.Close();
            comd.Connection.Close();

            decimal somaAdicional = 0; 

            //Pegar o valor da multa 1 
            comd.CommandText = "SELECT Valor FROM Multa_Adicional WHERE Condominio = @Condominio AND Codigo = '1'";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condominio", ComboCondominio.SelectedValue);

            comd.Connection.Open();
            reader = comd.ExecuteReader();
            decimal valorMulta1 = 0;
            if (reader.HasRows)
            {
                reader.Read();
                valorMulta1 = reader.GetDecimal(0);
            }

            reader.Close();
            comd.Connection.Close();

            somaAdicional = somaAdicional + (multa1 * valorMulta1);

            //Pegar o valor da multa 2 
            comd.CommandText = "SELECT Valor FROM Multa_Adicional WHERE Condominio = @Condominio AND Codigo = '2'";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condominio", ComboCondominio.SelectedValue);

            comd.Connection.Open();
            reader = comd.ExecuteReader();
            decimal valorMulta2 = 0;
            if (reader.HasRows)
            {
                reader.Read();
                valorMulta2 = reader.GetDecimal(0);
            }
            reader.Close();
            comd.Connection.Close();

            somaAdicional = somaAdicional + (multa2 * valorMulta2);

            //Pegar o valor da multa 3
            comd.CommandText = "SELECT Valor FROM Multa_Adicional WHERE Condominio = @Condominio AND Codigo = '3'";
            comd.Parameters.Clear();
            comd.Parameters.AddWithValue("Condominio", ComboCondominio.SelectedValue);

            comd.Connection.Open();
            reader = comd.ExecuteReader();
            decimal valorMulta3 = 0;
            if (reader.HasRows)
            {
                reader.Read(); 
                valorMulta3 = reader.GetDecimal(0);
            }
            reader.Close();
            comd.Connection.Close();

            somaAdicional = somaAdicional + (multa2 * valorMulta2);

            decimal soma = valor + somaAdicional; 


            comd.CommandText = "INSERT INTO DEBITO (CPF_Condomino, Mes, Valor, Situacao) VALUES (@Condomino, @Me, @Valor, @Situacao)";
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Me", ComboMes.Text);
            comd.Parameters.AddWithValue("Valor", soma);
            comd.Parameters.AddWithValue("Situacao", 1);

            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

            LabCadDebito.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
