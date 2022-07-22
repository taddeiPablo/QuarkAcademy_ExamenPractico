using System;
using System.Collections.Generic;
using System.Text;
using Cotizador_Entity_Library.Enums;

namespace Cotizador_Entity_Library.Entities
{
    public class Camisa: Prenda
    {
        private TipoCuello tcuello;
        private TipoManga tmanga;

        public TipoCuello Tipo_Cuello
        {
            get => this.tcuello;
        }
        public TipoManga Tipo_manga
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

        public Camisa(TipoCuello tcuello, TipoManga tmanga, double precio_unitario, int cant_unidades_stock, Calidad calidad)
            :base(calidad, precio_unitario, cant_unidades_stock)
        {
            this.tcuello = tcuello;
            this.tmanga = tmanga;
        }
    }
}
