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
    public partial class ProductosComponent : UserControl
    {
        List<ProductoDataGrid> listaProductos = new List<ProductoDataGrid>();

        public ProductosComponent()
        {
            InitializeComponent();
            ListarProductos();
        }

        public void ListarProductos()
        {
            dgvProductos.DataSource = null;
            listaProductos = ControladorEmpresa.GetInstancia().GetProductos();
            dgvProductos.DataSource = listaProductos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos()
            {
                nombre = txtNombre.Text,
                cantidad = txtCantidad.Text,
                precio = txtPrecio.Text,
                Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession()
            };
            
            ControladorEmpresa.GetInstancia().AgregarProducto(producto);
            ListarProductos();

        }
    }
}
