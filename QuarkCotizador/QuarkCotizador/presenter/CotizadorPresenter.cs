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
        
        private int camisaTipoCuello = 1;// tipos de cuellos
        private int camisaTipoManga = 3;// tipos de mangas
        private int calidadPrenda = 2; // calidad de las prendas
        private int pantalonTipo = 5; //tipo pantalon
        private int tipoFiltro = 1; // filtro seleccionado o camisas o pantalones

        #region Properties propias del Presenter
        public int CamisaTipoCuello
        {
            get => this.camisaTipoCuello;
            set => this.camisaTipoCuello = value;
        }
        public int CamisaTipoManga
        {
            get => this.camisaTipoManga;
            set => this.camisaTipoManga = value;
        }
        public int CalidadPrenda
        {
            get => this.calidadPrenda;
            set => this.calidadPrenda = value;
        }
        public int PantalonTipo
        {
            get => this.pantalonTipo;
            set => this.pantalonTipo = value;
        }
        public int TipoFiltro
        {
            get => this.tipoFiltro;
            set => this.tipoFiltro = value;
        }
        #endregion

        public CotizadorPresenter(IView viewmain)
        {
            this.viewMain = viewmain;
            this.model = CotizadorModel.sharedInstance();
        }

        #region Metodos que seran llamados en la GUI
        public void init()
        {
            viewMain.init_Tienda(this.model.nombre_tienda(), this.model.direccion_tienda());
            viewMain.init_Vendedor(this.model.nombre_apellido_Vendedor(), this.model.cod_vendedor());
        }
        public void limpiar_filtro()
        {
            this.camisaTipoCuello = 1;
            this.camisaTipoManga = 3;
            this.calidadPrenda = 2;
            this.pantalonTipo = 5;
            this.tipoFiltro = 1;
        }
        public void filtrar_prendas()
        {
            TipoFiltro Tipo_filtro = (TipoFiltro)this.tipoFiltro;
            switch (Tipo_filtro)
            {
                case modelo.TipoFiltro.Camisa:
                    (int Camisa_Cant_Unidades_Stock, double Camisa_Precio_Unitario) = this.model.filtroCamisas(this.camisaTipoManga, this.camisaTipoCuello, this.calidadPrenda);
                    this.viewMain.valores_filtros(Camisa_Cant_Unidades_Stock, Camisa_Precio_Unitario);
                    break;
                case modelo.TipoFiltro.Pantalon:
                    (int  pantalon_Cant_Unidades_Stock1, double pantalon_Precio_Unitario1) = this.model.filtroPantalones(this.pantalonTipo, this.calidadPrenda);
                    this.viewMain.valores_filtros(pantalon_Cant_Unidades_Stock1, pantalon_Precio_Unitario1);
                    break;
                default:
                    break;
            }
        }
        public void cotizar(int cantidadPrendas)
        {
            try
            {
                this.viewMain.mostrarCotizacionFinal(this.model.Cotizador(cantidadPrendas, this.tipoFiltro));
            }
            catch (Exception ex)
            {
                this.viewMain.excepcion_stock(ex.Message);
            }
        }
        #endregion
    }
}
