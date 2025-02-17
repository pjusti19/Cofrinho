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

        public AreaDeTrabalhoViewModel()
        {
            ConteudoAtual = new areaDeTrabalho(this); // Começa com Tela1
        }

        public void MudarParaCadastroDeExtrato()
        {
            ConteudoAtual = new cadastrarExtrato(this);
        }



    }

}
