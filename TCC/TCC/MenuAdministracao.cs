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
        public MenuAdministracao()
        {
            InitializeComponent();
        }

        public void pegaOrigemDosDados(Object form)
        {
            if (form.GetType() == typeof(Login))
            {
                //Essa é a forma direta, pois se colocarmos o CAST/Conversão implícita entre (),
                //podemos acessar o conteúdo diretamente

                /* Só pra~não ferrar com o código
                 * this.lblNomeUsuario.Text = ((Login)form).Usuario;
                 */
            }
        }

    }
}
