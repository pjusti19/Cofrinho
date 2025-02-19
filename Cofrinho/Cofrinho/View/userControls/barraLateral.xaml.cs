using System.Windows.Controls;
using Cofrinho.ViewModel;

namespace Cofrinho.View.userControls
{

    public partial class barraLateral : UserControl
    {
        public barraLateral()
        {
            InitializeComponent();
            barraLateralViewModel barraLateralViewModel = new barraLateralViewModel();
            DataContext = barraLateralViewModel;
        }

        private void btnVisualizar_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
