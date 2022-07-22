using System;
using System.Collections.Generic;
using System.Text;
using Cotizador_Entity_Library.Enums;

namespace Cotizador_Entity_Library.Entities
{
    public abstract class Prenda
    {
        protected Calidad calidad;
        protected double precio_unitario;
        protected int cant_unidades_stock;

        protected Prenda(Calidad calidad, double precio_unitario, int cant_unidades_stock)
        {
            this.calidad = calidad;
            this.precio_unitario = precio_unitario;
            this.cant_unidades_stock = cant_unidades_stock;
        }
    }
}
