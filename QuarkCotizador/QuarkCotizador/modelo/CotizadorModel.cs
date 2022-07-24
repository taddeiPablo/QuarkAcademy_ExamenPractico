using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador_Entities_Library.Entities;
using Cotizador_Entities_Library.Enums;
using QuarkCotizador.modelo.utils;

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
        private Camisa _Camisa = null;
        private Pantalon _Pantalon = null;

        private static CotizadorModel cotizadormodel = null;

        public static CotizadorModel sharedInstance()
        {
            if (cotizadormodel == null)
            {
                cotizadormodel = new CotizadorModel();
            }
            return cotizadormodel;
        }

        public String cod_vendedor()
        {
            return "#" + " " +Convert.ToString(_vendedor.CodVendedor);
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
        public double Cotizador(int cantidadPrendas, int tipoFiltro)
        {
            int descuentoCamisas = 10;
            int aumentoCamisas = 3;
            int descuentoPantalones = 12;
            int aumentoPantalones = 30;
            double total_con_descuento = 0.0;
            double totalParcial = 0.0;
            double total_cotizacion = 0.0;
            Cotizacion nuevaCotizacion = null;
            if (tipoFiltro == 1)
            {
                totalParcial = _Camisa.Precio_Unitario * cantidadPrendas;
                if (_Camisa.Tipo_Cuello == TipoPrenda.Cuello_mao && _Camisa.Tipo_manga == TipoPrenda.Manga_corta)
                {
                    double porcentajeDescuento = totalParcial * descuentoCamisas / 100;
                    double procentajeAumento = totalParcial * aumentoCamisas / 100;
                    total_con_descuento = totalParcial - porcentajeDescuento;
                    total_cotizacion = total_con_descuento + procentajeAumento;
                }else if(_Camisa.Tipo_manga == TipoPrenda.Manga_corta)
                {
                    double porcentajeDescuento = totalParcial * descuentoCamisas / 100;
                    total_cotizacion = totalParcial - porcentajeDescuento;
                }else if(_Camisa.Tipo_Cuello == TipoPrenda.Cuello_mao)
                {
                    double porcentajeAumento = totalParcial * aumentoCamisas / 100;
                    total_cotizacion = totalParcial + porcentajeAumento;
                }
                else
                {
                    total_cotizacion = totalParcial;
                }
                nuevaCotizacion = new Cotizacion(CreacionIds.idCotizacion(), DateTime.Now, _vendedor.CodVendedor, _Camisa, cantidadPrendas, total_cotizacion);
                cargarCotizacion(nuevaCotizacion);
            }
            else if (tipoFiltro == 2)
            {
                totalParcial = _Pantalon.Precio_Unitario * cantidadPrendas;
                if (_Pantalon.Tipo_Calidad == Calidad.Premium)
                {
                    double porcentajeAumento = totalParcial * aumentoPantalones / 100;
                    totalParcial = totalParcial + porcentajeAumento;
                    if (_Pantalon.Tipo_Pantalon == TipoPrenda.Chupin)
                    {
                        double porcentajeDescuento = totalParcial * descuentoPantalones / 100;
                        totalParcial = totalParcial - porcentajeDescuento;
                    }
                    total_cotizacion = totalParcial;
                }
                else
                {
                    total_cotizacion = totalParcial;
                }
                nuevaCotizacion = new Cotizacion(CreacionIds.idCotizacion(), DateTime.Now, _vendedor.CodVendedor, _Pantalon, cantidadPrendas, total_cotizacion);
                cargarCotizacion(nuevaCotizacion);
            }
            return total_cotizacion;
        }

        private void cargarCotizacion(Cotizacion nuevaCotizacion)
        {
            foreach ( Vendedor item in _tienda.Vendedores)
            {
                if (item.CodVendedor == _vendedor.CodVendedor)
                {
                    item.Historial_Vendedor.addCotizacion(nuevaCotizacion);
                }
            }
        }

        public List<Cotizacion> lista_cotizaciones()
        {
            List<Cotizacion> historial = null;
            foreach (Vendedor item in _tienda.Vendedores)
            {
                if (item.CodVendedor == _vendedor.CodVendedor)
                {
                    historial = item.Historial_Vendedor.HistorialCotizaciones;
                    break;
                }
            }
            return historial;
        }

        public CotizadorModel()
        {
            _vendedor = new Vendedor(CreacionIds.codVendedor(), "Pablo", "Taddei");
            _tienda = new Tienda("El shaddai", "calle 880 N°: 3324 Quilmes");
            _tienda.addVendedor(_vendedor);
            _tienda.Listado_de_prendas = creacion_listado_de_prendas();
        }
        private List<Prenda> creacion_listado_de_prendas()
        {
            List<Prenda> listado_prendas = new List<Prenda>();
            //500 camisas manga corta
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_corta, 1000, 100, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_corta, 1100, 100, Calidad.Premium));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_corta, 900, 150, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_corta, 1000, 150, Calidad.Premium));
            // 500 camisas manga larga
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_larga, 1000, 75, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_larga, 1900, 75, Calidad.Premium));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_larga, 1000, 175, Calidad.Standard));
            listado_prendas.Add(new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_larga, 1900, 175, Calidad.Premium));
            // 1500 pantalones chupines
            listado_prendas.Add(new Pantalon(TipoPrenda.Chupin, Calidad.Standard, 1000, 750));
            listado_prendas.Add(new Pantalon(TipoPrenda.Chupin,Calidad.Premium, 1900, 750));
            // 500 pantalones comunes
            listado_prendas.Add(new Pantalon(TipoPrenda.Comun, Calidad.Standard, 950, 250));
            listado_prendas.Add(new Pantalon(TipoPrenda.Comun, Calidad.Premium, 1100, 250));
            return listado_prendas;
        }
        public (string, string) filtroCamisas(int tipoManga, int tipoCuello, int calidad)
        {
            foreach (Prenda item in _tienda.Listado_de_prendas)
            {
                if (item is Camisa)
                {
                    Camisa camisa = (Camisa)item;
                    if (camisa.Tipo_manga == (TipoPrenda)tipoManga && camisa.Tipo_Cuello == (TipoPrenda)tipoCuello && camisa.Tipo_Calidad == (Calidad)calidad)
                    {
                        _Camisa = camisa;
                        break;
                    }
                }
            }
            if (_Camisa != null)
            {
                return (Convert.ToString(_Camisa.Cant_Unidades_Stock), Convert.ToString(_Camisa.Precio_Unitario));
            }
            else
            {
                return ("0", "0000");
            }
        }
        public (string, string) filtroPantalones(int tipoPantalon, int calidad)
        {
            foreach (Prenda item in _tienda.Listado_de_prendas)
            {
                if (item is Pantalon)
                {
                    Pantalon pantalon = (Pantalon)item;
                    if (pantalon.Tipo_Pantalon == (TipoPrenda)tipoPantalon && pantalon.Tipo_Calidad == (Calidad)calidad)
                    {
                        _Pantalon = pantalon;
                        break;
                    }
                }
            }
            if (_Pantalon != null)
            {
                return (Convert.ToString(_Pantalon.Cant_Unidades_Stock), Convert.ToString(_Pantalon.Precio_Unitario));
            }
            else
            {
                return ("0", "0000");
            }            
        }
    }
}
