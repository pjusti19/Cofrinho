using System.Collections.ObjectModel;
using Cofrinho.Model.DAO;
using Cofrinho.Model.DTO;
using Cofrinho.ViewModel.ViewModelHelper;

namespace Cofrinho.ViewModel
{
    internal class barraLateralViewModel : BaseViewModel
    {

        private ObservableCollection<Extrato> _extratos;
        public ObservableCollection<Extrato> Extratos
        {
            get => _extratos;
            set
            {
                _extratos = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(MostrarLista));
                OnPropertyChanged(nameof(MostrarMensagem));
            }
        }

        public bool MostrarLista => Extratos.Count > 0;
        public bool MostrarMensagem => Extratos.Count == 0;

        public barraLateralViewModel()
        {
            CarregarRegistros();
        }

        private void CarregarRegistros()
        {
            using (ExtratoDAO extratoDAO = new ExtratoDAO())
            {
                List<Extrato> lista = extratoDAO.ObterTodos();
                Extratos = new ObservableCollection<Extrato>(lista);
            }
        }

    }

}
