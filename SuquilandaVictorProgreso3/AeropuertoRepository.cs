using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SuquilandaVictorProgreso3
{
    internal class AeropuertoRepository : IAeropuertoRepository
    {
        private readonly SQLiteConnection database;
        public AeropuertoRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Arepuerto>();
        }
        public void GuardarArepuerto(Arepuerto arepuerto, string vsuquilanda)
        {
            arepuerto.VSuquilanda = vsuquilanda;
            database.Insert(arepuerto);
        }
        public List<Arepuerto> ObtenerArepuertos()
        {
            return database.Table<Arepuerto>().ToList();
        }
    }
}
