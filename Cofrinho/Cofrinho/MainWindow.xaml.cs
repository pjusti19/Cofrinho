using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cofrinho.View.userControls;
using MahApps.Metro.IconPacks;

namespace Cofrinho
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Obtém a referência do controle de menu (assumindo que ele tem o nome 'BarraMenu' no XAML)
            BarraMenu.MinimizarClicked += btnMinimizar_Click;
            BarraMenu.MaximizarClicked += btnMaximizar_Click;
            BarraMenu.FecharClicked += btnFechar_Click;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Content is PackIconMaterial icon)
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                    icon.Kind = PackIconMaterialKind.WindowMaximize;
                }
                else
                {
                    WindowState = WindowState.Maximized;
                    icon.Kind = PackIconMaterialKind.WindowRestore;
                }
            }
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}