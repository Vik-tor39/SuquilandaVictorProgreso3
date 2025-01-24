using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuquilandaVictorProgreso3
{
    internal class BuscarAeropuertoViewModel : BaseViewModel
    {
        private string _searchQuery;
        private string _searchResult;
        private readonly IAeropuertoRepository _repo;

        public string SearchQuery
        {
            get => _searchQuery;
            set => SetProperty(ref _searchQuery, value);
        }
        public string SearchResult
        {
            get => _searchResult;
            set => SetProperty(ref _searchResult, value);
        }
        public ICommand SearchCommand { get; }
        public ICommand ClearCommand { get; }
        public BuscarAeropuertoViewModel(IAeropuertoRepository repo)
        {
            _repo = repo;
            SearchCommand = new Command(async () => await searchAeropuerto());
            ClearCommand = new Command(async () => SearchQuery = string.Empty);
        }
        private async Task searchAeropuerto()
        {
            using var client = new HttpClient();
            var url  = $"https://api.openweathermap.org/data/2.5/weather?q={SearchQuery}&appid=4b3
        }
    }
}
