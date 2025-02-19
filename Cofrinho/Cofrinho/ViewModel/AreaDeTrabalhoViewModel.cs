using System.Collections.ObjectModel;
using System.Windows.Controls;
using Cofrinho.Model.DAO;
using Cofrinho.Model.DTO;
using Cofrinho.View.userControls;
using Cofrinho.ViewModel.ViewModelHelper;

namespace Cofrinho.ViewModel
{
    public class AreaDeTrabalhoViewModel : BaseViewModel
    {
        private UserControl _conteudoAtual;
        public UserControl ConteudoAtual
        {
            get => _conteudoAtual;
            set
            {
                _conteudoAtual = value;
                OnPropertyChanged();
            }
        }

        public barraLateralViewModel BarraLateralViewModel { get; private set; } 

        public AreaDeTrabalhoViewModel()
        {
            BarraLateralViewModel = new barraLateralViewModel(); // Instanciando o barraLateralViewModel
            ConteudoAtual = new areaDeTrabalho(this);
        }

        public void MudarParaCadastroDeExtrato()
        {
            ConteudoAtual = new cadastrarExtrato(this, BarraLateralViewModel);
        }
    }
}
