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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoDois
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {

            // Informações de Registro

            string nomeFantasia = txtNomeFantasia.Text;
            string razaoSocial = txtRazaoSocial.Text;
            string cnpj = txtCnpj.Text;
            string incricaoEstadual = txtIncricao.Text;
            string teleEscola = txtTeleEscola.Text;
            string tipo = "";
            DatePicker dataCriacao = dtCriacao;
            string responsavel = txtResponsavel.Text;
            
            // Localização
            string rua = txtRua.Text;
            string num = txtNum.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string telefone = txtTele.Text;
            string email = txtEmail.Text;


            if (rdPublico.IsChecked == true) 
            {
               tipo = rdPublico.Content.ToString();

            }
            if(rdPrivado.IsChecked==true)
            {
                tipo = rdPrivado.Content.ToString();
            }

            MessageBox.Show("INFORMAÇÕES DE REGISTROS :......." + Environment.NewLine +
                "Nome fantasia : " + nomeFantasia + Environment.NewLine +
                " Razão Social :" + razaoSocial + Environment.NewLine +
                "CNPJ : " + cnpj + Environment.NewLine +
                "Incrição Estadual : " + incricaoEstadual + Environment.NewLine +
                "Telefone Escola : " + teleEscola + Environment.NewLine +
                "Tipo" + tipo + Environment.NewLine +
                "Responsável : " + responsavel + Environment.NewLine +
                "Data criação: " + dataCriacao);

            MessageBox.Show("INFORMAÇÕES DE LOCALIZAÇÃO :......." + Environment.NewLine + Environment.NewLine +
                "Rua :" + rua + Environment.NewLine +
                "Nº : " + num + Environment.NewLine +
                "Bairro : " + bairro + Environment.NewLine +
                "Complemento : " + complemento + Environment.NewLine +
                "CEP : " + cep + Environment.NewLine +
                "Cidade : " + cidade + Environment.NewLine +
                "Estado : " + estado + Environment.NewLine +
                "Telefone Pessoal : " + telefone + Environment.NewLine +
                "E-mail : " + email);


            // Informações de registro

            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
            txtIncricao.Clear();
            txtTeleEscola.Clear();
            txtResponsavel.Clear();
            rdPublico.IsChecked = false;
            rdPrivado.IsChecked = false;
            dataCriacao.SelectedDate = null;

            // Localização 

            txtRua.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtTele.Clear();
            txtEmail.Clear();
            txtEstado.SelectedItem = null;
        }
    }
}
