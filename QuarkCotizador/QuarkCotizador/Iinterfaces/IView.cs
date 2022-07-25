using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkCotizador.Iinterfaces
{
    public interface IView
    {
        void init_Tienda(string nombreTienda, string direccion);
        void init_Vendedor(string nombre_y_apellido_vendedor, string codVendedor);
        void valores_filtros(int unidadStock, double precioUnitario);
        void excepcion_stock(string mensaje);

        void mostrarCotizacionFinal(double CotizacionFinal);
    }
}
