﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador_Entities_Library.Entities;
using Cotizador_Entities_Library.Enums;

namespace QuarkCotizador.modelo
{
    public class CotizadorModel
    {
        private Vendedor _vendedor;
        private Tienda _tienda;

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

        public void Cotizador()
        {

        }

        public CotizadorModel()
        {
            _vendedor = new Vendedor(10, "Pablo", "Taddei");
            _tienda = new Tienda("El shaddai", "calle 880 N°: 3324 Quilmes");
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
    }
}