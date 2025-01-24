using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuquilandaVictorProgreso3
{
    internal class AeropuertoViewModel : BaseViewModel
    {
        private readonly IAeropuertoRepository _repository;
        public ObservableCollection<AeropuertoDisplay> Aeropuertos { get; set; }

        public AeropuertoViewModel(IAeropuertoRepository repository)
        {
            _repository = repository;
            Aeropuertos = new ObservableCollection<AeropuertoDisplay>();
            CargarAeropuertos();
        }
        private void CargarAeropuertos()
        {
            var aeropuertos = _repository.ObtenerArepuertos();
            foreach (var aeropuerto in aeropuertos)
            {
                Aeropuertos.Add(new AeropuertoDisplay
                {
                    DisplayText = $"Name: {aeropuerto.Name}, " +
                    $"Country: {aeropuerto.Country}, " +
                    $"Latitude: {aeropuerto.Latitude}, " +
                    $"Longitude: {aeropuerto.Longitude}, " +
                    $"Email: {aeropuerto.email}, " +
                    $"VSuquilanda: {aeropuerto.VSuquilanda}"
                });
            }
        }
    }
}
