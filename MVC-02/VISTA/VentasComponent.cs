﻿using System;
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
        private List<VentaDataGrid> ventas = new List<VentaDataGrid>();

        public VentasComponent()
        {
            InitializeComponent();
            venta = new VentaDataGrid();
            venta.CrearVenta();
            ventas = ControladorEmpresa.GetInstancia().GetVentas();
            ListarVentas();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmVenta");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
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

        public void ListarVentas()
        {
            dgvVentas.DataSource = null;
            ventas = ControladorEmpresa.GetInstancia().GetVentas();
            dgvVentas.DataSource = ventas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (venta.Cliente == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            if (venta.Producto == null) { 
                MessageBox.Show("Seleccione un producto."); 
                return;
            }
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return;
            }
            if(nudCantidad.Value > venta.GetVentas().Productos.cantidad)
            {
                MessageBox.Show($"Falta(n) {Math.Abs(nudCantidad.Value - venta.GetVentas().Productos.cantidad)} unidad(es) de {venta.GetVentas().Productos.nombre}");
                return;
            }
            if (venta.Empleado == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }
            venta.GetVentas().cantidad = (int) nudCantidad.Value;
            venta.GetVentas().total = venta.GetVentas().Productos.precio * (int) nudCantidad.Value;
            ControladorEmpresa.GetInstancia().AgregarVenta(venta);
            lblCliente.Text = null;
            lblCliente.Visible = false;
            lblProducto.Text = null;
            lblProducto.Visible = false;
            lblEmpleado.Text = null;
            lblEmpleado.Visible = true;
            nudCantidad.Value = 0;
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
                venta.Producto = seleccion.producto.Nombre;
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

        private void VentasComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarVentas();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Seleccione una venta para cancelar.");
                return;
            }
            if (MessageBox.Show($"Desea cancelar la venta seleccionada?","Cancelar Venta",MessageBoxButtons.OKCancel) == DialogResult.OK) {
                ControladorEmpresa.GetInstancia().EliminarVenta(ventas[dgvVentas.SelectedRows[0].Index]);
                ListarVentas();
            }
        }
    }
}
