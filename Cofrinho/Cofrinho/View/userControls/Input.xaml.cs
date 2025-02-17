using System.Windows;
using System.Windows.Controls;

namespace Cofrinho.View.userControls
{
    public partial class Input : UserControl
    {
        public Input()
        {
            InitializeComponent();
        }

        // Propriedade para o texto do label
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(Input), new PropertyMetadata("Label"));

        // Propriedade para o valor do input
        public string InputValue
        {
            get { return (string)GetValue(InputValueProperty); }
            set { SetValue(InputValueProperty, value); }
        }
        public static readonly DependencyProperty InputValueProperty =
            DependencyProperty.Register("InputValue", typeof(string), typeof(Input), new PropertyMetadata(""));

        // Propriedade para a largura do input
        public double InputWidth
        {
            get { return (double)GetValue(InputWidthProperty); }
            set { SetValue(InputWidthProperty, value); }
        }
        public static readonly DependencyProperty InputWidthProperty =
            DependencyProperty.Register("InputWidth", typeof(double), typeof(Input), new PropertyMetadata(200.0));

        // Propriedade para a altura do input
        public double InputHeight
        {
            get { return (double)GetValue(InputHeightProperty); }
            set { SetValue(InputHeightProperty, value); }
        }
        public static readonly DependencyProperty InputHeightProperty =
            DependencyProperty.Register("InputHeight", typeof(double), typeof(Input), new PropertyMetadata(30.0));

    }
}
