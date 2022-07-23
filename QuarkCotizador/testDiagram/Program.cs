using System;
using System.Collections.Generic;
using Cotizador_Entity_Library.Entities;
using Cotizador_Entity_Library.Enums;

namespace testDiagram
{
    class Program
    {

        static void Main(string[] args)
        {

            Vendedor unvendedor;
            Tienda unatienda;
            Cotizacion unaCotizacion;
            List<Prenda> ListaPrendas = new List<Prenda>();
            
            unvendedor = new Vendedor(10000, "pablo", "taddei");
            
            unatienda = new Tienda("tienda de prueba", "calle que te importa 123");

            Pantalon nuevoPantalon = new Pantalon(TipoPrenda.Chupin, Calidad.Standard, 100.50, 100);
            Pantalon otroPantalon = new Pantalon(TipoPrenda.Comun, Calidad.Premium, 160.00, 200);
            Camisa nuevaCamisa = new Camisa(TipoPrenda.Cuello_mao, TipoPrenda.Manga_corta, 130.20, 120, Calidad.Premium);
            Camisa otroCamisa = new Camisa(TipoPrenda.Cuello_comun, TipoPrenda.Manga_larga, 100, 50, Calidad.Standard);
            ListaPrendas.Add(nuevoPantalon);
            ListaPrendas.Add(otroPantalon);
            ListaPrendas.Add(nuevaCamisa);
            ListaPrendas.Add(otroCamisa);


            unatienda.Vendedores.Add(unvendedor);
            unatienda.Listado_de_prendas = ListaPrendas;

            // vamos a crear un cotizador
            unaCotizacion = new Cotizacion(120, new DateTime(), 10000, nuevoPantalon, 4, 1200);
            // esto es solo un ejemplo armarlo de mejor manera
            unatienda.Vendedores[0].Historial_Vendedor.addCotizacion(unaCotizacion);
        }
    }
}
