using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using MODELO;

namespace VISTA
{
    public partial class VentasComponent : UserControl
    {

        private VentaDataGrid venta;
        private List<VentaDataGrid> ventas;

        public VentasComponent()
        {
            InitializeComponent();
            venta = new VentaDataGrid();
            venta.CrearVenta();
            ventas = ControladorEmpresa.GetInstancia().GetVentas();
            ListarVentas();
            var permisos = ControladorSeguridad.GetInstancia().GetControlsAllowed("frmVenta");
            foreach (var control in GetButtonControls(this))
            {
                var permiso = permisos.FirstOrDefault(x => x == control.Name);
                if (permiso != null)
                    control.Enabled = true;
                else
                    control.Enabled = false;
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

        public void ListarVentas()
        {
            dgvVentas.DataSource = null;
            ventas = ControladorEmpresa.GetInstancia().GetVentas();
            dgvVentas.DataSource = ventas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            venta.GetVentas().cantidad = tbCantidad.Text;
            venta.GetVentas().total = (int.Parse(venta.GetVentas().Productos.precio) * int.Parse(tbCantidad.Text)).ToString();
            ControladorEmpresa.GetInstancia().AgregarVenta(venta);
            lblCliente.Text = null;
            lblCliente.Visible = false;
            lblProducto.Text = null;
            lblProducto.Visible = false;
            lblEmpleado.Text = null;
            lblEmpleado.Visible = true;
            venta = new VentaDataGrid();
            venta.CrearVenta();
            ListarVentas();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente seleccion = new frmSeleccionarCliente();
            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                venta.GetVentas().Cliente = seleccion.cliente.GetCliente();
                venta.Cliente = seleccion.cliente.Nombre;
                lblCliente.Text = seleccion.cliente.Nombre;
                lblCliente.Visible = true;
            }
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            frmSeleccionarProducto seleccion = new frmSeleccionarProducto();
            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                venta.GetVentas().Productos = seleccion.producto.GetProductos();
                venta.Cliente = seleccion.producto.Nombre;
                lblProducto.Text = seleccion.producto.Nombre;
                lblProducto.Visible = true;
            }
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            frmSeleccionarEmpleado seleccion = new frmSeleccionarEmpleado();
            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                venta.GetVentas().Empleado = seleccion.empleado.GetEmpleado();
                venta.Empleado = seleccion.empleado.Nombre;
                lblEmpleado.Text = seleccion.empleado.Nombre;
                lblEmpleado.Visible = true;
            }
        }
    }
}
