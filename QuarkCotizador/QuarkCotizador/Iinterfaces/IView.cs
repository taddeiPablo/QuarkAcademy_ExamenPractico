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
    }
}
