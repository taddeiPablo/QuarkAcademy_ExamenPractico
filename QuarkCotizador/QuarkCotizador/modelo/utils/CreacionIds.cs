using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkCotizador.modelo.utils
{
    public static class CreacionIds
    {
        private static int id_Cotizacion_ultimo = 0;
        // metodo cuyo fin es crear un codVendedor unico
        public static int codVendedor()
        {
            Random random = new Random();
            int codVendedor = random.Next(100, 10000);
            return codVendedor;
        }

        // metodo cuyo fin es crear un id de cotizacion unico por cada cotizacion
        public static int idCotizacion()
        {
            Random random = new Random();
            int id_Cotizacion = 0;
            do
            {
                id_Cotizacion = random.Next(10, 1000000);

            } while (id_Cotizacion == id_Cotizacion_ultimo);
            id_Cotizacion_ultimo = id_Cotizacion;

            return id_Cotizacion;
        }
    }
}
