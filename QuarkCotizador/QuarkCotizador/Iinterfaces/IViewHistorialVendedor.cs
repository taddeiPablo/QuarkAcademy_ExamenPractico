using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador_Entities_Library.Entities;

namespace QuarkCotizador.Iinterfaces
{
    public interface IViewHistorialVendedor
    {
        void cargarGrilla_de_cotizaciones(List<Cotizacion> listado_de_Cotizaciones);
    }
}
