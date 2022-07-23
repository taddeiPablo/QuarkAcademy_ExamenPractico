using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkCotizador.Iinterfaces;
using QuarkCotizador.modelo;

namespace QuarkCotizador.presenter
{
    public class CotizadorPresenter
    {
        private IView viewMain;
        private CotizadorModel model;

        public CotizadorPresenter(IView viewmain)
        {
            this.viewMain = viewmain;
            this.model = new CotizadorModel();
        }

        public void init()
        {
            viewMain.init_Tienda(this.model.nombre_tienda(), this.model.direccion_tienda());
            viewMain.init_Vendedor(this.model.nombre_apellido_Vendedor(), this.model.cod_vendedor());
        }
    }
}
