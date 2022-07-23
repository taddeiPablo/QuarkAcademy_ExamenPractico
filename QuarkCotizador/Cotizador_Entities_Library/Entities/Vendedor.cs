using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_Entities_Library.Entities
{
    public class Vendedor
    {
        private int cod_vendedor;
        private string nombre;
        private string apellido;
        private HistorialVendedor historial_vendedor;

        public int CodVendedor
        {
            get => this.cod_vendedor;
        }
        public string Nombre
        {
            get => this.nombre;
        }
        public string Apellido
        {
            get => this.apellido;
        }
        public HistorialVendedor Historial_Vendedor
        {
            get => this.historial_vendedor;
        } 

        public Vendedor(int cod_vendedor, string nombre, string apellido)
        {
            this.cod_vendedor = cod_vendedor;
            this.nombre = nombre;
            this.apellido = apellido;
            this.historial_vendedor = new HistorialVendedor();
        }
    }
}
