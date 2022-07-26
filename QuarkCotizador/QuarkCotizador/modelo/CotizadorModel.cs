using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador_Entities_Library.Entities;
using Cotizador_Entities_Library.Enums;

namespace QuarkCotizador.modelo
{
    public enum TipoFiltro
    {
        Camisa = 1,
        Pantalon = 2
    }
    public class CotizadorModel
    {
        private Vendedor _vendedor;
        private Tienda _tienda;

        #region Implementacion de un singleton
        private static CotizadorModel cotizadormodel = null;
        public static CotizadorModel sharedInstance()
        {
            if (cotizadormodel == null)
            {
                cotizadormodel = new CotizadorModel();
            }
            return cotizadormodel;
        }
        #endregion

        #region properties
        public String cod_vendedor()
        {
            return "#" + " " + Convert.ToString(_vendedor.CodVendedor);
        }
        public String nombre_apellido_Vendedor()
        {
            return _vendedor.Nombre + " " + _vendedor.Apellido;
        }
        public String nombre_tienda()
        {
            return _tienda.Nombre;
        }
        public String direccion_tienda()
        {
            return _tienda.Direccion;
        }
        #endregion

        #region llamadas al cotizador
        public double cotizador(int cantidadPrendas, int tipoFiltro)
        {
            return this._tienda.Cotizador(cantidadPrendas, tipoFiltro);
        }
        public Vendedor historialVendedor()
        {
            return this._tienda.HistorialVendedor();
        }
        #endregion

        public CotizadorModel()
        {
            _vendedor = new Vendedor(codVendedor(), "Pablo", "Taddei");
            _tienda = new Tienda("El Shaddai", "calle 880 N°: 3324 Quilmes");
            _tienda.agregar_Vendedor(_vendedor);
            _tienda.agregar_Listado_de_Prendas(creacion_listado_de_prendas());
        }

        #region Creacion del stock + filtros
        private List<Prenda> creacion_listado_de_prendas()
        {
            List<Prenda> listado_prendas = new List<Prenda>();
            //500 camisas manga corta
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_corta, 100, 100, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_corta, 100, 100, Calidad.Premium));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_corta, 100, 150, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_corta, 100, 150, Calidad.Premium));
            // 500 camisas manga larga
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_larga, 100, 75, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_larga, 100, 75, Calidad.Premium));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_larga, 100, 175, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_larga, 100, 175, Calidad.Premium));
            // 1500 pantalones chupines
            listado_prendas.Add(new Pantalon(TipoPrenda.Chupin, Calidad.Standard, 100, 750));
            listado_prendas.Add(new Pantalon(TipoPrenda.Chupin, Calidad.Premium, 100, 750));
            // 500 pantalones comunes
            listado_prendas.Add(new Pantalon(TipoPrenda.Comun, Calidad.Standard, 100, 250));
            listado_prendas.Add(new Pantalon(TipoPrenda.Comun, Calidad.Premium, 100, 250));
            return listado_prendas;
        }
        public (int, double) modelfiltroCamisas(int tipoManga, int tipoCuello, int calidad)
        {
            return _tienda.filtroCamisas(tipoManga, tipoCuello, calidad);
        }
        public (int, double) modelfiltroPantalones(int tipoPantalon, int calidad)
        {
            return _tienda.filtroPantalones(tipoPantalon, calidad);
        }
        #endregion

        // metodo cuyo fin es crear un codVendedor unico
        private static int codVendedor()
        {
            Random random = new Random();
            int codVendedor = random.Next(100, 10000);
            return codVendedor;
        }
    }
}
