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

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void ComboCondomino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //criar um DataTable
            DataTable dtTabelas = new DataTable();

            //definir a string de conexao
            String strConn = @"Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;";

            //define a conexao
            SqlConnection conn = new SqlConnection(strConn);

            //Cria o comando 
            string comando = String.Format("select CPF from Condomino where CPF = {0}", ComboCondominio.Text);

            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter(comando, conn);




            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            ComboCondominio.DataSource = dtTabelas;

            ComboCondominio.ValueMember = "CPF";
        }
    }
}
