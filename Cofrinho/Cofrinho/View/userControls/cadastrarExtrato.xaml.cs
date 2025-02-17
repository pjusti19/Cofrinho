﻿using System;
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
    /// <summary>
    /// Interação lógica para cadastrarExtrato.xam
    /// </summary>
    public partial class cadastrarExtrato : UserControl
    {

        private AreaDeTrabalhoViewModel viewModel;

        public cadastrarExtrato(AreaDeTrabalhoViewModel areaDeTrabalhoViewModel)
        {
            InitializeComponent();
            viewModel = areaDeTrabalhoViewModel;
        }

        private void btnCriar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
