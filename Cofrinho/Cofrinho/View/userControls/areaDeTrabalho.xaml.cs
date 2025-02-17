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
using Cofrinho.ViewModel;

namespace Cofrinho.View.userControls
{
    public partial class areaDeTrabalho : UserControl
    {
        private AreaDeTrabalhoViewModel viewModel;

        public areaDeTrabalho(AreaDeTrabalhoViewModel areaDeTrabalhoViewModel)
        {
            InitializeComponent();
            viewModel = areaDeTrabalhoViewModel;
        }

        private void btnCriarExtrato_Click(object sender, RoutedEventArgs e)
        {
            viewModel.MudarParaCadastroDeExtrato();
        }
    }
}
