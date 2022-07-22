using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_Entity_Library.Entities
{
    public class Cotizacion
    {
        private int numIdentificacion;
        private DateTime fecha_y_hora;
        private int cod_vendedor;
        private Prenda prenda_cotizada;
        private int cant_de_unidades_cotizadas;
        private double result_calc_cotizadas;

        public int NumIdentificacion { get => numIdentificacion; }
        public DateTime Fecha_y_Hora { get => fecha_y_hora; }
        public int Cod_Vendedor { get => cod_vendedor; }
        public Prenda Prenda_Cotizada { get => prenda_cotizada; }
        public int Cant_de_Unidades_Cotizadas { get => cant_de_unidades_cotizadas; set => cant_de_unidades_cotizadas = value; }
        public double Result_Calc_Cotizadas { get => result_calc_cotizadas; set => result_calc_cotizadas = value; }

        public Cotizacion(int numIdentificacion, DateTime fecha_y_hora, int cod_vendedor, Prenda prenda_cotizada, int cant_de_unidades_cotizadas, double result_calc_cotizadas)
        {
            this.numIdentificacion = numIdentificacion;
            this.fecha_y_hora = fecha_y_hora;
            this.cod_vendedor = cod_vendedor;
            this.prenda_cotizada = prenda_cotizada;
            this.cant_de_unidades_cotizadas = cant_de_unidades_cotizadas;
            this.result_calc_cotizadas = result_calc_cotizadas;
        }
    }
}
