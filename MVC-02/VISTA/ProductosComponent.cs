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
        ProductoDataGrid producto = null;
        int indice;

        public ProductosComponent()
        {
            InitializeComponent();
            ListarProductos();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmProductos");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
                {
                    control.Enabled = true;
                }
                else
                {
                    if (control.Name == "btnModificarProducto")
                    {
                        dgvProductos.CellDoubleClick -= dgvProductos_CellDoubleClick;
                    }
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
            //Validaciones para Agregar Producto

            if (string.IsNullOrEmpty(txtNombre.Text) || !txtNombre.Text.ToCharArray().All(x => char.IsLetterOrDigit(x)))
            {
                MessageBox.Show("El nombre del producto ingresado es inválido.");
                return;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad ingresada es inválida.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio ingresado es inválido.");
                return;
            }

            producto = new ProductoDataGrid(new Productos()
            {
                nombre = txtNombre.Text,
                cantidad = (int)nudCantidad.Value,
                precio = (int)nudPrecio.Value,
                Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession()
            });

            ControladorEmpresa.GetInstancia().AgregarProducto(producto);
            ListarProductos();

            producto = null;
            LimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (indice == -1 || listaProductos.Count <= indice)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            producto = listaProductos.ElementAt(indice);

            if (
                MessageBox.Show($"Desea eliminar el producto: {producto.Nombre}",
                "Eliminar producto", MessageBoxButtons.OKCancel) == DialogResult.OK
                )
            {
                ControladorEmpresa.GetInstancia().EliminarProducto(producto);
                ListarProductos();
                producto = null;
                LimpiarCampos();
            }
        }

        private void ProductosComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarProductos();
        }

        private void btnModProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || !txtNombre.Text.ToCharArray().All(x => char.IsLetterOrDigit(x)))
            {
                MessageBox.Show("El nombre del producto ingresado es inválido.");
                return;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad ingresada es inválida.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio ingresado es inválido.");
                return;
            }

            if (producto == null) { MessageBox.Show("Seleccione un producto."); return; }
            producto.GetProductos().nombre = txtNombre.Text;
            producto.GetProductos().precio = (int)nudPrecio.Value;
            producto.GetProductos().cantidad = (int)nudCantidad.Value;
            ControladorEmpresa.GetInstancia().ModificarProducto(producto);
            ListarProductos();
            producto = null;

            btnAgregarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;

            LimpiarCampos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = listaProductos.ElementAt(e.RowIndex);

            txtNombre.Text = producto.Nombre;
            nudCantidad.Value = producto.Cantidad;
            nudPrecio.Value = producto.Precio;

            btnAgregarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;

        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = null;
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
        }
    }
}
