using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADOR;

namespace VISTA
{
    public partial class frmSeleccionarProducto : Form
    {
        private List<ProductoDataGrid> productos;
        public ProductoDataGrid producto;
        public frmSeleccionarProducto()
        {
            InitializeComponent();
            productos = ControladorEmpresa.GetInstancia().GetProductos();
            lbProductos.DataSource = productos.Select(x => x.Nombre).ToList();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedIndex != -1)
            {
                producto = productos[lbProductos.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
