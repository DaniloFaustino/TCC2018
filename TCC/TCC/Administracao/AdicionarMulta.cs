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
    public partial class AdicionarMulta : Form
    {
        public string Adm { get; set; }

        public AdicionarMulta(string adm)
        {
            InitializeComponent();
            this.Adm = adm; 
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;


            comd.CommandText = "INSERT INTO ADICIONAL (Condomino, Codigo, Mes) VALUES (@Condomino, @Codigo, @Mes)";
            comd.Parameters.AddWithValue("Condomino", ComboCondomino.SelectedValue);
            comd.Parameters.AddWithValue("Codigo", ComboCodigo.SelectedValue);
            comd.Parameters.AddWithValue("Mes", ComboMes.Text);


            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

            LabCadMulta.Visible = true;  
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

            ComboCondomino.Visible = true;  

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

        private void ComboCodigo_DropDown(object sender, EventArgs e)
        {

            // criar um DataTable
            DataTable dtTabelas = new DataTable();

            //definir a string de conexao
            String strConn = @"Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;";

            //define a conexao
            SqlConnection conn = new SqlConnection(strConn);

            //Cria o comando 
            string comando = String.Format("select Codigo, Nome from Multa_Adicional where Condominio = {0}", ComboCondominio.SelectedValue);


            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter(comando, conn);




            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            ComboCodigo.DataSource = dtTabelas;
            ComboCodigo.DisplayMember = "Nome";
            ComboCodigo.ValueMember = "Codigo";
        }
    }
}
