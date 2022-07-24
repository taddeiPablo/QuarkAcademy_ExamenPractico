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
        private bool limpiar = true;

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
        public void valores_filtros(string unidadStock, string precioUnitario)
        {
            LabelUnidadStock.Text = unidadStock;
            labelPrecioUnitario.Text = precioUnitario;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            presenter = new CotizadorPresenter(this);
            presenter.init();
            filtrar_prendas_check();
        }

        private void filtrar_prendas_check()
        {
            checkBoxMangaCorta.Enabled = camisaRadioBtn.Checked == true ? camisaRadioBtn.Checked : false;
            checkBoxCuelloMao.Enabled = camisaRadioBtn.Checked == true ? camisaRadioBtn.Checked : false;
            checkBoxChupin.Enabled = PantalonesRadioBtn.Checked == true ? PantalonesRadioBtn.Checked : false;
            if (camisaRadioBtn.Checked)
            {
                presenter.TipoFiltro = 1;
            }else if (PantalonesRadioBtn.Checked)
            {
                presenter.TipoFiltro = 2;
            }
            presenter.filtrar_prendas();
        }

        private void camisaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioCamisa = (RadioButton)sender;
            checkBoxMangaCorta.Enabled = radioCamisa.Checked;
            checkBoxCuelloMao.Enabled = radioCamisa.Checked;
            if (radioCamisa.Checked)
            {
                presenter.TipoFiltro = 1;
                presenter.filtrar_prendas();
            }
        }

        private void PantalonesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioPantalon = (RadioButton)sender;
            checkBoxChupin.Enabled = radioPantalon.Checked;
            if (radioPantalon.Checked)
            {
                presenter.TipoFiltro = 2;
                presenter.filtrar_prendas();
            }
        }
        private void checkBoxMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkManga = (CheckBox)sender;
            presenter.CamisaTipoManga = checkManga.Checked ? 4 : 3;
            presenter.filtrar_prendas();
        }
        private void checkBoxCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkCuello = (CheckBox)sender;
            presenter.CamisaTipoCuello = checkCuello.Checked ? 2 : 1;
            presenter.filtrar_prendas();
        }
        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkChupin = (CheckBox)sender;
            presenter.PantalonTipo = checkBoxChupin.Checked ? 6 : 5;
            presenter.filtrar_prendas();
        }
        private void radioBtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioStandard = (RadioButton)sender;
            if (radioStandard.Checked)
            {
                presenter.CalidadPrenda = 2;
            }
            presenter.filtrar_prendas();
        }
        private void radioBtnPremium_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioPremium = (RadioButton)sender;
            if (radioPremium.Checked)
            {
                presenter.CalidadPrenda = 1;
            }
            presenter.filtrar_prendas();
        }
        private void recargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            camisaRadioBtn.Checked = limpiar;
            checkBoxMangaCorta.Enabled = limpiar;
            checkBoxMangaCorta.Checked = !limpiar;
            checkBoxCuelloMao.Enabled = limpiar;
            checkBoxCuelloMao.Checked = !limpiar;
            PantalonesRadioBtn.Checked = !limpiar;
            checkBoxChupin.Enabled = !limpiar;
            checkBoxChupin.Checked = !limpiar;
            txtCantidad.Text = string.Empty;
            labelTotal.Text = string.Empty;

            presenter.limpiar_filtro();
            presenter.filtrar_prendas();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Historial_Vendedores hvFrom = new Historial_Vendedores();
            hvFrom.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("esta seguro que desea salir de la aplicacion", "¡¡¡ Atencion !!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCantidad.Text))
            {
                int cantidadPrendas = Convert.ToInt32(txtCantidad.Text);
                presenter.cotizar(cantidadPrendas);
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "[0-9]"))
            {
               txtCantidad.Text = "";
            }
        }
        public void mostrarCotizacionFinal(double CotizacionFinal)
        {
            labelTotal.Text = Convert.ToString(CotizacionFinal);
        }
    }
}
