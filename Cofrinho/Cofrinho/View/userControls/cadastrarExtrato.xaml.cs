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
using Cofrinho.Model.DTO;
using Cofrinho.ViewModel;

namespace Cofrinho.View.userControls
{
    public partial class cadastrarExtrato : UserControl
    {

        private AreaDeTrabalhoViewModel _viewModel;
        private readonly ExtratoDAO _extratoDAO;
        private barraLateralViewModel _barraLateralViewModel;
        public cadastrarExtrato(AreaDeTrabalhoViewModel areaDeTrabalhoViewModel, barraLateralViewModel barraLateralViewModel)
        {
            InitializeComponent();
            _viewModel = areaDeTrabalhoViewModel;
            _extratoDAO = new ExtratoDAO();
            _barraLateralViewModel = barraLateralViewModel;
            _barraLateralViewModel = barraLateralViewModel;
        }

        private void btnCriar_Click(object sender, RoutedEventArgs e)
        {
            // Recebendo os valores dos inputs
            string nome = inputNome.InputValue;
            string proprietario = inputProprietario.InputValue;
            string descricao = inputDescricao.InputValue;

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(proprietario) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Extrato extrato = new Extrato
            {
                NomeRegistro = nome,
                NomeProprietario = proprietario,
                Descricao = descricao
            };

            _extratoDAO.Inserir(extrato);
            // Adiciona o novo extrato na lista de exibição da tela
            _barraLateralViewModel.AdicionarExtrato(extrato);

            // Reseta os inputs
            inputNome.InputValue = "";
            inputProprietario.InputValue = "";
            inputDescricao.InputValue = "";

            MessageBox.Show("Extrato cadastrado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
