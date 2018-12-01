using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    static class Program
    {

        static Login telaLogin;
        static MenuAdministracao telaPrincipalAdm;
        static MenuCondomino telaPrincipalCondomino;
         

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            telaLogin = new Login();
            telaPrincipalAdm = new MenuAdministracao();
            telaPrincipalCondomino = new MenuCondomino();

            telaLogin.FormClosed += new FormClosedEventHandler(telaLogin_FormClosed);
            telaPrincipalAdm.FormClosed += new FormClosedEventHandler(telaPrincipalAdm_FormClosed);
            
            telaLogin.Show();

            Application.Run();
        }

        static void telaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (telaLogin.ClicouBotaoLogar && telaLogin.LogouAdm)
            {
                telaPrincipalAdm.StartPosition = FormStartPosition.Manual;
                telaPrincipalAdm.Location = telaLogin.Location;

                telaPrincipalAdm.pegaOrigemDosDados(telaLogin);

                telaPrincipalAdm.Show();
            }
            else if (telaLogin.ClicouBotaoLogar && telaLogin.LogouCondomino)
            {
                telaPrincipalAdm.StartPosition = FormStartPosition.Manual;
                telaPrincipalAdm.Location = telaLogin.Location;

                //telaPrincipalCondomino.pegaOrigemDosDados(telaLogin);

                telaPrincipalCondomino.Show();
            }
            else
            {
                if (telaLogin.ClicouCadastrar)
                {
                    //façam essa parte!! O que acontece se clicar em cadastrar
                }
                else
                {
                    //sender não cliquei em nada, e porque o usuário clicou no botão x para fecha a janela
                    Application.Exit();
                }
            }
        }
        static void telaPrincipalAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
