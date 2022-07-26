﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkCotizador.modelo;
using QuarkCotizador.Iinterfaces;

namespace QuarkCotizador.presenter
{
    public class HistorialPresenter
    {
        private CotizadorModel modelHistorial;
        private IViewHistorialVendedor viewHistorial;

        public HistorialPresenter(IViewHistorialVendedor ivhv)
        {
            this.viewHistorial = ivhv;
            this.modelHistorial = CotizadorModel.sharedInstance();
        }

        #region Metodos de la IViewHistorialVendedor
        // aqui cargamos la grilla
        public void cargarGrilla()
        {
            this.viewHistorial.cargarGrilla_de_cotizaciones(this.modelHistorial.historialVendedor().Historial_Vendedor.HistorialCotizaciones);
        }
        #endregion
    }
}
