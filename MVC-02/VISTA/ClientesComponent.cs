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
    public partial class ClientesComponent : UserControl
    {
        private List<ClienteDataGrid> ListaClientes = new List<ClienteDataGrid>();
        int indice;
        ClienteDataGrid cliente = null;
        public ClientesComponent()
        {
            InitializeComponent();
            ListarClientes();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmClientes");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
                {
                    control.Enabled = true;
                }
                else
                {
                    if (control.Name == "btnModificarCliente")
                    {
                        dgvClientes.CellDoubleClick -= dvgClientes_CellDoubleClick;
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


        private void ListarClientes() //Lista los clientes en el DataGridView
        {
            dgvClientes.DataSource = null;
            ListaClientes = ControladorEmpresa.GetInstancia().GetClientes();
            dgvClientes.DataSource = ListaClientes;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)    //Agrega un cliente
        {
            //Validaciones para Agregar Empleado

            if (String.IsNullOrEmpty(txtNombreCliente.Text) || !txtNombreCliente.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El nombre ingresado es inválido.");
                return;
            }

            if (nudEdadCliente.Value <= 0)
            {
                MessageBox.Show("La edad ingresada es inválida.");
                return;
            }

            if (String.IsNullOrEmpty(txtTelCliente.Text) || !txtTelCliente.Text.ToCharArray().All(x => char.IsDigit(x)) ||
                txtTelCliente.Text.Length > 13)
            {
                MessageBox.Show("El teléfono ingresado no es válido.");
                return;
            }

            ClienteDataGrid cliente = new ClienteDataGrid(new Cliente()
            {
                nombre = txtNombreCliente.Text,
                edad = int.Parse(nudEdadCliente.Text),
                telefono = txtTelCliente.Text,
                Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession()
            });

            ControladorEmpresa.GetInstancia().AgregarCliente(cliente);
            ListarClientes();

            LimpiarCampos();

        }

        private void dvgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                indice = dgvClientes.SelectedRows[0].Index;
            }
        }

        private ClienteDataGrid ClienteSeleccionado()
        {
            if (indice == -1) return null;
            return ListaClientes.ElementAt(indice);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombreCliente.Text) || !txtNombreCliente.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El nombre ingresado es inválido.");
                return;
            }

            if (nudEdadCliente.Value <= 0)
            {
                MessageBox.Show("La edad ingresada es inválida.");
                return;
            }

            if (String.IsNullOrEmpty(txtTelCliente.Text) || !txtTelCliente.Text.ToCharArray().All(x => char.IsDigit(x)) ||
                txtTelCliente.Text.Length > 13)
            {
                MessageBox.Show("El teléfono ingresado no es válido.");
                return;
            }

            if (cliente == null) { MessageBox.Show("Seleccione un cliente."); return; }
            cliente.GetCliente().nombre = txtNombreCliente.Text;
            cliente.GetCliente().edad = int.Parse(nudEdadCliente.Text);
            cliente.GetCliente().telefono = txtTelCliente.Text;

            ControladorEmpresa.GetInstancia().ModificarCliente(cliente);
            ListarClientes();
            LimpiarCampos();

            btnAgregarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
            cliente = null;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado() == null) return;
            ClienteDataGrid cliente = ClienteSeleccionado();
            if (cliente.GetCliente().Ventas.Count > 0)
            {
                MessageBox.Show("El cliente no puede ser eliminado porque tiene ventas.");
                return;
            }
            if (
                MessageBox.Show($"Desea eliminar el Cliente: {cliente.Nombre}",
                "Eliminar cliente", MessageBoxButtons.OKCancel) == DialogResult.OK
                )
            {
                ControladorEmpresa.GetInstancia().EliminarCliente(cliente);
                ListarClientes();
                LimpiarCampos();
            }
        }

        private void ClientesComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarClientes();
        }

        //Llena los campos al hacer doble clic para modificar fácilmente
        private void dvgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            LimpiarCampos();

            btnAgregarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;

            cliente = ListaClientes.ElementAt(e.RowIndex);

            txtNombreCliente.Text = cliente.Nombre;
            nudEdadCliente.Value = cliente.Edad;
            txtTelCliente.Text = cliente.Telefono;
        }
        private void LimpiarCampos()
        {
            txtNombreCliente.Text = null;
            nudEdadCliente.Value = 0;
            txtTelCliente.Text = null;
        }
    }
}
