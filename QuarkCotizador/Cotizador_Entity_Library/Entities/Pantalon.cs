using System;
using System.Collections.Generic;
using System.Text;
using Cotizador_Entity_Library.Enums;

namespace Cotizador_Entity_Library.Entities
{
    public class Pantalon: Prenda
    {
        private TipoPantalon tpantalon;

        public TipoPantalon Tipo_Pantalon
        {
            get => this.tpantalon;
        }
        public double Precio_Unitario
        {
            get => this.precio_unitario;
        }
        public int Cant_Unidades_Stock
        {
            get => this.cant_unidades_stock;
        }
        public Pantalon(TipoPantalon tpantalon, Calidad calidad, double precio_unitario, int cant_unidades_stock)
            :base(calidad, precio_unitario, cant_unidades_stock)
        {
            this.tpantalon = tpantalon;
        }
    }
}
