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

namespace Cofrinho.View.userControls
{
    public partial class barraMenu : UserControl
    {
        // Eventos personalizados
        public event RoutedEventHandler MinimizarClicked;
        public event RoutedEventHandler MaximizarClicked;
        public event RoutedEventHandler FecharClicked;

        public barraMenu()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            MinimizarClicked?.Invoke(this, e);
        }

        private void btnMaximizar_Click(object sender, RoutedEventArgs e)
        {
            MaximizarClicked?.Invoke(sender, e);
        }
        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            FecharClicked?.Invoke(this, e);
        }
    }
}