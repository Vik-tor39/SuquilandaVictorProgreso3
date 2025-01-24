﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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
            var url  = $"https://freetestapi.com/api/v1/airports?search={SearchQuery}";
            var response = await client.GetFromJsonAsync<List<Arepuerto>>(url);
            if (response == null || response.Any())
            {
                var aeropuerto = response.First();
                _repo.GuardarArepuerto(aeropuerto, "VSuquilanda");
                SearchResult = $"Name: {aeropuerto.Name}, " +
                    $"Country: {aeropuerto.Country}, " +
                    $"Latitude: {aeropuerto.Latitude}, " +
                    $"Longitude: {aeropuerto.Longitude}, " +
                    $"Email: {aeropuerto.email}, " +
                    $"VSuquilanda: {aeropuerto.VSuquilanda}";
            }
            else
            {
                SearchResult = "No results found";
            }
        }
    }
}
