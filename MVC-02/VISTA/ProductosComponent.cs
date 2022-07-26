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
        int indice;

        public ProductosComponent()
        {
            InitializeComponent();
            ListarProductos();
            var permisos = ControladorSeguridad.GetInstancia().GetControlsAllowed("frmProductos");
            foreach (var control in GetButtonControls(this))
            {
                var permiso = permisos.FirstOrDefault(x => x == control.Name);
                if (permiso != null)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }
        //Usar recursion para obtener todos los hijos de un control
        private List<Control> GetButtonControls(Control padre)
        {
            List<Control> controles = new List<Control>();
            //Caso base es el caso en donde no haya hijos ya que no entra al foreach
            foreach (Control c in padre.Controls)
            {
                controles.AddRange(GetButtonControls(c));
                if (c is Button)
                    controles.Add(c);
            }
            //En el caso base, devuelve la lista vacia, si no, devuelve los controles
            return controles;
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Productos producto = listaProductos.ElementAt(indice).GetProductos();
            ControladorEmpresa.GetInstancia().EliminarProducto(producto);
            ListarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
            }
        }

        
    }
}
