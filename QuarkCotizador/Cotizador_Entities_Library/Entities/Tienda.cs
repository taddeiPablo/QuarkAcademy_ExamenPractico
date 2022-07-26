using System;
using System.Collections.Generic;
using System.Text;
using Cotizador_Entities_Library.Enums;

namespace Cotizador_Entities_Library.Entities
{
    public class Tienda
    {
        private string nombre;
        private string direccion;
        private Vendedor _vendedor;
        private List<Prenda> listado_de_prendas;
        private List<Vendedor> vendedores;
        private Camisa _Camisa = null;
        private Pantalon _Pantalon = null;
        private string mensaje_de_error = "La cantidad ingresada supera las unidades en Stock ";
        private static int id_Cotizacion_ultimo = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Prenda> Listado_de_prendas { get => listado_de_prendas; }
        public List<Vendedor> Vendedores { get => vendedores; }

        public Camisa Camisa
        {
            get => this._Camisa;
        }
        public Pantalon Pantalon
        {
            get => this._Pantalon;
        }

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.listado_de_prendas = new List<Prenda>();
            this.vendedores = new List<Vendedor>();
        }

        public void agregar_Vendedor(Vendedor unvendedor)
        {
            this._vendedor = unvendedor;
            this.vendedores.Add(this._vendedor);
        }
        public void agregar_Listado_de_Prendas(List<Prenda> listadoPrendas)
        {
            this.listado_de_prendas = listadoPrendas;
        }

        #region LOGICA DE NEGOCIOS
        public (int, double) filtroCamisas(int tipoManga, int tipoCuello, int calidad)
        {
            _Camisa = null;
            foreach (Prenda item in this.listado_de_prendas)
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
                return (_Camisa.Cant_Unidades_Stock, _Camisa.Precio_Unitario);
            }
            else
            {
                return (0, 0.0);
            }
        }
        public (int, double) filtroPantalones(int tipoPantalon, int calidad)
        {
            _Pantalon = null;
            foreach (Prenda item in this.listado_de_prendas)
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
                return (_Pantalon.Cant_Unidades_Stock, _Pantalon.Precio_Unitario);
            }
            else
            {
                return (0, 0.0);
            }
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
                if (cantidadPrendas > _Camisa.Cant_Unidades_Stock)
                    throw new Exception(mensaje_de_error);

                totalParcial = _Camisa.Precio_Unitario * cantidadPrendas;
                if (_Camisa.Tipo_Cuello == TipoPrenda.Cuello_mao && _Camisa.Tipo_manga == TipoPrenda.Manga_corta)
                {
                    double porcentajeDescuento = totalParcial * descuentoCamisas / 100;
                    double procentajeAumento = totalParcial * aumentoCamisas / 100;
                    total_con_descuento = totalParcial - porcentajeDescuento;
                    total_cotizacion = total_con_descuento + procentajeAumento;
                }
                else if (_Camisa.Tipo_manga == TipoPrenda.Manga_corta)
                {
                    double porcentajeDescuento = totalParcial * descuentoCamisas / 100;
                    total_cotizacion = totalParcial - porcentajeDescuento;
                }
                else if (_Camisa.Tipo_Cuello == TipoPrenda.Cuello_mao)
                {
                    double porcentajeAumento = totalParcial * aumentoCamisas / 100;
                    total_cotizacion = totalParcial + porcentajeAumento;
                }
                else
                {
                    total_cotizacion = totalParcial;
                }
                nuevaCotizacion = new Cotizacion(idCotizacion(), DateTime.Now, _vendedor.CodVendedor, _Camisa, cantidadPrendas, total_cotizacion);
                cargarCotizacion(nuevaCotizacion);
            }
            else if (tipoFiltro == 2)
            {
                if (cantidadPrendas > _Pantalon.Cant_Unidades_Stock)
                    throw new Exception(mensaje_de_error);

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
                nuevaCotizacion = new Cotizacion(idCotizacion(), DateTime.Now, _vendedor.CodVendedor, _Pantalon, cantidadPrendas, total_cotizacion);
                cargarCotizacion(nuevaCotizacion);
            }
            return total_cotizacion;
        }
        private void cargarCotizacion(Cotizacion nuevaCotizacion)
        {
            foreach (Vendedor item in this.vendedores)
            {
                if (item.CodVendedor == _vendedor.CodVendedor)
                {
                    item.Historial_Vendedor.agregarCotizacion(nuevaCotizacion);
                }
            }
        }
        public Vendedor HistorialVendedor()
        {
            Vendedor elvendedor = null;
            foreach (Vendedor item in this.vendedores)
            {
                if (item.CodVendedor == _vendedor.CodVendedor)
                {
                    elvendedor = item;
                }
            }
            return elvendedor;
        }
        #endregion
        // metodo cuyo fin es crear un id de cotizacion unico por cada cotizacion
        private static int idCotizacion()
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
