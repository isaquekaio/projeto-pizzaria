using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace Pizzaria
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtEntrar_Click(object sender, RoutedEventArgs e)
        {
            int idLogin;
            string senhaC, senhaN;
            MFuncionario funcPadrao = new MFuncionario();
            funcPadrao.Id = 10;
            funcPadrao.Senha = "admin";
            
            idLogin.Parset.int(txtID.Text);
            //senhaLogin(txtSenhaFun.Text);

            SHA1Managed Sha = new SHA1Managed();
            senhaC = Sha.ComputeHash(System.Text.Encoding.Default.GetBytes(txtSenhaFun.Text));
            senhaN = Sha.ComputeHash(System.Text.Encoding.Default.GetBytes(Senha));

            if (senhaC == senhaN && idLogin == Id)
                MainMenu menu = new MainMenu();
            if (w.ShowDialog().Value)
            {

            }

        }
    }
}
