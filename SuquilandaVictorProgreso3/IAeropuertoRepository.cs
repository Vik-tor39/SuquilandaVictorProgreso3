﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuquilandaVictorProgreso3
{
    internal interface IAeropuertoRepository
    {
        void GuardarArepuerto(Arepuerto arepuerto, string vsuquilanda);
        List<Arepuerto> ObtenerArepuertos();
    }
}
