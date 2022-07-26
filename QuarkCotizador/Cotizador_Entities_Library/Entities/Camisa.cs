using System;
using System.Collections.Generic;
using System.Text;
using Cotizador_Entities_Library.Enums;

namespace Cotizador_Entities_Library.Entities
{
    public class Camisa: Prenda
    {
        private TipoPrenda tcuello;
        private TipoPrenda tmanga;

        public TipoPrenda Tipo_Cuello
        {
            get => this.tcuello;
        }
        public TipoPrenda Tipo_manga
        {
            get => this.tmanga;
        }
        public double Precio_Unitario
        {
            get => this.precio_unitario;
        }
        public int Cant_Unidades_Stock
        {
            get => this.cant_unidades_stock;
        }
        public Calidad Tipo_Calidad
        {
            get => this.calidad;
        }

        public Camisa(TipoPrenda tcuello, TipoPrenda tmanga, double precio_unitario, int cant_unidades_stock, Calidad calidad)
            :base(calidad, precio_unitario, cant_unidades_stock)
        {
            this.tcuello = tcuello;
            this.tmanga = tmanga;
        }

        public override string ToString()
        {
            string valorColumna = "Camisa";
            return valorColumna;
        }
    }
}
