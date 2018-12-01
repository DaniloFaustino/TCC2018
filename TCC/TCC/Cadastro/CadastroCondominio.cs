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
    public partial class CadastroCondominio : Form
    {
        public bool checkCondo = false;
        public bool checkAdm = false;
        public bool checkExiste = false; 


        public CadastroCondominio()
        {
            InitializeComponent();
        }

        //Ação de cadastrar
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = TCC; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            //Verifica se a opção escolhida foi cadastrar condomínio
            if (checkCondo)
            {
                //Verifica se todos os campos foram preenchidos
                if (TxtCNPJ.Text == "" || TxtNome.Text == "" || TxtValorCond.Text == "" || ComboAptNumero.Text == "" || TxtEndereco.Text == "" || TxtCNPJ.Text.Length > 14)
                {
                    LabCadCondo.Visible = true;
                    LabCadCondo.Text = "Dados incorretos ou incompletos";
                }
                //Ação se todos os campos forem preenchidos
                else
                {
                    //Verifica se já existe algum CNPJ de condomínio cadastrado
                    comd.CommandText = "SELECT CNPJ FROM CONDOMINIO WHERE CNPJ = @Teste";
                    comd.Parameters.AddWithValue("Teste", TxtCNPJ.Text);

                    comd.Connection.Open();
                    SqlDataReader reader = comd.ExecuteReader();
                    string cnpj = "";
                    if (reader.HasRows)
                    {
                        reader.Read();
                        cnpj = reader.GetString(0);
                    }
                    reader.Close();
                    comd.Connection.Close();

                    if (cnpj != "")
                    {
                        LabCadCondo.Visible = true;

                        LabCadCondo.Text = "CNPJ já cadastrado";
                    }
                    //Se não existir nenhum CNPJ, ação de cadastrar condomínio
                    else
                    {
                        double valor = Convert.ToDouble(TxtValorCond.Text);
                        comd.CommandText = "INSERT INTO CONDOMINIO (CNPJ, Nome, Endereco, Qtd_Apt, Valor) VALUES (@CNPJ, @Nome, @Endereco, @Quantidade, @Valor)";
                        comd.Parameters.AddWithValue("CNPJ", TxtCNPJ.Text);
                        comd.Parameters.AddWithValue("Nome", TxtNome.Text);
                        comd.Parameters.AddWithValue("Endereco", TxtEndereco.Text);
                        comd.Parameters.AddWithValue("Quantidade", ComboAptNumero.Text);
                        comd.Parameters.AddWithValue("Valor", valor);

                        conex.Open();
                        comd.ExecuteNonQuery();
                        conex.Close();

                        LabCadCondo.Visible = true;
                        LabCadCondo.Text = "Condomínio cadastrado com sucesso!";
                    }


                }
            }
            //Verifica se a opção escolhida foi cadastrar administrador
            else if (checkAdm)
            {
                //Verifica se a opção de adm já cadastrado foi escolhida 
                if (checkExiste)
                {
                    //Verifica se o campo do CNPJ do condomínio e o CPF/CNPJ do administrador foram preenchidas 
                    if (TxtCNPJAdm.Text == "" || TxtCNPJ_CPF.Text == "")
                    {
                        LabCadAdm.Visible = true;
                        LabCadAdm.Text = "Informação inválida";
                    }
                    //Caso estejam preenchidas
                    else
                    {
                        //Verifica se o adm existe mesmo 
                        comd.CommandText = "SELECT CPF_CNPJ FROM ADMINISTRACAO WHERE CPF_CNPJ = @Check";
                        comd.Parameters.AddWithValue("Check", TxtCNPJAdm.Text);

                        comd.Connection.Open();
                        SqlDataReader ler = comd.ExecuteReader();
                        string adm = "";
                        if (ler.HasRows)
                        {
                            ler.Read();
                            adm = ler.GetString(0);
                        }
                        ler.Close();
                        comd.Connection.Close();

                        //Verifica se o condomínio existe
                        comd.CommandText = "SELECT CNPJ FROM CONDOMINIO WHERE CNPJ = @Verificar";
                        comd.Parameters.AddWithValue("Verificar", TxtCNPJAdm.Text);

                        comd.Connection.Open();
                        ler = comd.ExecuteReader();
                        string cond = "";
                        if (ler.HasRows)
                        {
                            ler.Read();
                            cond = ler.GetString(0);
                        }
                        ler.Close();
                        comd.Connection.Close();

                        //Se não existir adm com aquele CPF/CNPJ
                        if (adm == "" || cond == "")
                        {
                            LabCadAdm.Visible = true;
                            LabCadAdm.Text = "Informações inválidas";
                        }
                        //Caso exista adm e condomínio
                        else
                        {
                            comd.CommandText = "INSERT INTO AdmCondominio (CPF_CNPJ, Condominio) VALUES (@CPF, @Condominio)";
                            comd.Parameters.AddWithValue("CPF", TxtCNPJ_CPF.Text);
                            comd.Parameters.AddWithValue("Condominio", TxtCNPJAdm.Text);

                            conex.Open();
                            comd.ExecuteNonQuery();
                            conex.Close();

                            LabCadAdm.Visible = true;
                            LabCadAdm.Text = "Administrador cadastrado com sucesso!";
                        }
                    }

                }
                else
                {
                    //Verifica se todos os campos foram preenchidos e se há igualdade entre as senhas
                    if (TxtCNPJ_CPF.Text == "" || TxtNomeAdm.Text == "" || TxtSenha.Text == "" || TxtConfirmarSenha.Text == "" || TxtSenha.Text != TxtConfirmarSenha.Text)
                    {

                        LabCadAdm.Visible = true;
                        LabCadAdm.Text = "Dados incorretos ou incompletos";
                    }
                    //Ação se todos os campos forem preenchidos
                    else
                    {
                        //Verifica se o condomínio escolhido existe
                        comd.CommandText = "SELECT CNPJ FROM CONDOMINIO WHERE CNPJ = @Cond";
                        comd.Parameters.AddWithValue("Cond", TxtCNPJAdm.Text);

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
                            LabCadAdm.Visible = true;

                            LabCadAdm.Text = "Não há condomínio cadastrado para esse CNPJ";
                        }

                        else
                        {
                            //Verifica se já existe algum CPF/CNPJ de admnistrador cadastrado para aquele condomínio
                            comd.CommandText = "SELECT CPF_CNPJ FROM ADMINISTRACAO WHERE CPF_CNPJ IN (SELECT CPF_CNPJ FROM AdmCondominio WHERE CPF_CNPJ = @Verificar AND Condominio = @Veri)";
                            comd.Parameters.AddWithValue("Verificar", TxtCNPJ_CPF.Text);
                            comd.Parameters.AddWithValue("Veri", TxtCNPJAdm.Text);

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
                                LabCadAdm.Visible = true;

                                LabCadAdm.Text = "CPF/CNPJ já cadastrado para esse condomínio";
                            }
                            //Se não existir nenhum CPF/CNPJ, ação de cadastrar admnistrador
                            else
                            {
                                comd.CommandText = "INSERT INTO ADMINISTRACAO (CPF_CNPJ, Senha, Nome) VALUES (@CPF, @Senha, @Nome)";
                                comd.Parameters.AddWithValue("CPF", TxtCNPJ_CPF.Text);
                                comd.Parameters.AddWithValue("Senha", TxtSenha.Text);
                                comd.Parameters.AddWithValue("Nome", TxtNomeAdm.Text);

                                conex.Open();
                                comd.ExecuteNonQuery();
                                conex.Close();

                                comd.CommandText = "INSERT INTO AdmCondominio (CPF_CNPJ, Condominio) VALUES (@CP, @Condominio)";
                                comd.Parameters.AddWithValue("CP", TxtCNPJ_CPF.Text);
                                comd.Parameters.AddWithValue("Condominio", TxtCNPJAdm.Text);

                                conex.Open();
                                comd.ExecuteNonQuery();
                                conex.Close();

                                

                                LabCadAdm.Visible = true;
                                LabCadAdm.Text = "Administrador cadastrado com sucesso!";
                            }
                        }
                    }
                }
            }
        }
        
        //Ação caso o cadastro de condomínio seja escolhido
        private void RadSelecionarCondo_CheckedChanged(object sender, EventArgs e)
        {
            GroupCondominio.Visible = true;
            checkCondo = true;
            GroupAdm.Visible = false;
            CheckExiste.Visible = false; 
        }

        //Ação caso o cadastro de admnistrador seja escolhido
        private void RadSelecionarAdm_CheckedChanged(object sender, EventArgs e)
        {
            GroupAdm.Visible = true;
            checkAdm = true;
            GroupCondominio.Visible = false;
            CheckExiste.Visible = true; 
        }

        private void CheckExiste_CheckedChanged(object sender, EventArgs e)
        {
            checkExiste = true; 
        }
    }
}
