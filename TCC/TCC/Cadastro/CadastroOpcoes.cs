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
    public partial class CadastroOpcoes : Form
    {
        public CadastroOpcoes()
        {
            InitializeComponent();
        }

        private void CadastroOpcoes_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadCond_Click(object sender, EventArgs e)
        {
            CadastroCondominio cadCondo = new CadastroCondominio();
            cadCondo.Show();
        }

        private void BtnCadApt_Click(object sender, EventArgs e)
        {
            CadastroCondomino CadCond = new CadastroCondomino();
            CadCond.Show();
        }
    }
}
