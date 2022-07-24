using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizador_Entities_Library.Entities;
using QuarkCotizador.Iinterfaces;
using QuarkCotizador.presenter;

namespace QuarkCotizador
{
    public partial class Historial_Vendedores : Form, IViewHistorialVendedor
    {
        private HistorialPresenter hPresenter;

        public Historial_Vendedores()
        {
            InitializeComponent();
        }

        public void cargarGrilla_de_cotizaciones(List<Cotizacion> listado_de_Cotizaciones)
        {
            dataGridCotizaciones.DataSource = listado_de_Cotizaciones;
        }

        private void Historial_Vendedores_Load(object sender, EventArgs e)
        {
            hPresenter = new HistorialPresenter(this);
            hPresenter.cargarGrilla();
        }
    }
}
