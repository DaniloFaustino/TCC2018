using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class MenuAdministracao : Form
    {
        public string Adm { get; set; }

        public MenuAdministracao()
        {
            InitializeComponent();
        }

        public void pegaOrigemDosDados(Login form)
        {
            this.Adm = ((Login)form).Usuario;
        }

        private void BtnCondominos_Click(object sender, EventArgs e)
        {
            CondominosAdm novoCondominos = new CondominosAdm(Adm);
            novoCondominos.ShowDialog(); 
        }

        private void BtnCondominios_Click(object sender, EventArgs e)
        {
            CondominioAdm novoCondominio = new CondominioAdm(Adm);
            novoCondominio.ShowDialog(); 
        }

        private void MenuAdministracao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
