using System;
using System.Collections.Generic;
using System.Text;

namespace Cotizador_Entities_Library.Entities
{
    public class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> listado_de_prendas;
        private List<Vendedor> vendedores;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Prenda> Listado_de_prendas { get => listado_de_prendas; }
        public List<Vendedor> Vendedores { get => vendedores; }

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.listado_de_prendas = new List<Prenda>();
            this.vendedores = new List<Vendedor>();
        }

        public void agregar_Vendedor(Vendedor unvendedor)
        {
            this.vendedores.Add(unvendedor);
        }

        public void agregar_Listado_de_Prendas(List<Prenda> listadoPrendas)
        {
            this.listado_de_prendas = listadoPrendas;
        }
    }
}
