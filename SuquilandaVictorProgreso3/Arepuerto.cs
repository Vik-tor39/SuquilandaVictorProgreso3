using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SuquilandaVictorProgreso3
{
    internal class Arepuerto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string email { get; set; }
        public string VSuquilanda { get; set; }
    }
    public class AeropuertoDisplay
    {
        public string DisplayText { get; set; }
    }
}
