using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PdaStorage.ViewModels
{
    public class StorageContainViewModel : ViewModelBase
    {
        private string _searchedMobName;
        private readonly ObservableCollection<PdaViewModel> _pdas;

        public ICommand DeleteCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand ResearchCommand { get; }

        public IEnumerable<PdaViewModel> Pdas => _pdas;

        public string SearchedMobName
        {
            get { return _searchedMobName; }
            set 
            {
                if(value == "rechercher un mob..")
                {
                    _searchedMobName = "";
                    OnPropertyChanged(nameof(SearchedMobName));
                    return;
                }

                _searchedMobName = value;
                OnPropertyChanged(nameof(SearchedMobName));
            }
        }

        public StorageContainViewModel()
        {
            _pdas = new ObservableCollection<PdaViewModel>();
            _searchedMobName = "rechercher un mob...";
            _pdas.Add(new PdaViewModel(new Models.Pda("Test1")));
            _pdas.Add(new PdaViewModel(new Models.Pda("Test2")));
            _pdas.Add(new PdaViewModel(new Models.Pda("Test3")));
        }


    }
}
