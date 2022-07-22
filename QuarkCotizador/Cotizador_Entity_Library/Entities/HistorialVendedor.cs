using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_Entity_Library.Entities
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

        public void addCotizacion(Cotizacion cotizacion)
        {
            this.historial_cotizaciones.Add(cotizacion);
        }
    }
}
