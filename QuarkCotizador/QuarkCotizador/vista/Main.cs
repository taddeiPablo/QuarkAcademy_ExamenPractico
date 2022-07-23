using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkCotizador.Iinterfaces;
using QuarkCotizador.presenter;

namespace QuarkCotizador
{
    public partial class Main : Form, IView
    {
        private CotizadorPresenter presenter;

        public Main()
        {
            InitializeComponent();
        }

        public void init_Tienda(string nombreTienda, string direccion)
        {
            nombre_tienda.Text = nombreTienda;
            DireccionTienda.Text = direccion;
        }
        public void init_Vendedor(string nombre_y_apellido_vendedor, string codVendedor)
        {
            nombre_y_apellido.Text = nombre_y_apellido_vendedor;
            Cod_vendedor.Text = codVendedor;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            presenter = new CotizadorPresenter(this);
            presenter.init();
            //checkBoxMangaCorta.Enabled = false;
        }
    }
}
