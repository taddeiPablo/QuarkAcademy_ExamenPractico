﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_Entities_Library.Entities
{
    public class HistorialVendedor
    {
        private List<Cotizacion> historial_cotizaciones;

        public List<Cotizacion> HistorialCotizaciones
        {
            get => this.historial_cotizaciones;
        }

        public HistorialVendedor()
        {
            this.historial_cotizaciones = new List<Cotizacion>();
        }

        public void agregarCotizacion(Cotizacion cotizacion)
        {
            this.historial_cotizaciones.Add(cotizacion);
        }
    }
}
