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
        public ClientesComponent()
        {
            InitializeComponent();
            ListarClientes();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmClientes");
            foreach (var control in GetButtonControls(this))
            {
                var permiso = permisos.FirstOrDefault(x => x == control.Name);
                if (permiso != null)
                {
                    control.Enabled = true;
                } else
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


        private void ListarClientes() //Lista los clientes en el DataGridView
        {
            dvgClientes.DataSource = null;
            ListaClientes = ControladorEmpresa.GetInstancia().GetClientes();
            dvgClientes.DataSource = ListaClientes;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)    //Agrega un cliente
        {
            Cliente cliente = new Cliente() //Construyo un cliente
            {
                nombre = txtNombreCliente.Text,
                edad = int.Parse(nudEdadCliente.Text),
                telefono = txtTelCliente.Text,
            };

            //Asigna la empresa al cliente
            cliente.Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession();

            ControladorEmpresa.GetInstancia().AgregarCliente(cliente);
            ListarClientes();

        }

        private void dvgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgClientes.SelectedRows.Count > 0)
            {
                indice = dvgClientes.SelectedRows[0].Index;
            }       
        }

        private ClienteDataGrid ClienteSeleccionado()
        {
            if (indice == -1) return null;
            return ListaClientes.ElementAt(indice);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado() == null) return;
            Cliente cliente = ClienteSeleccionado().GetCliente();
            cliente.nombre = txtNombreCliente.Text;
            cliente.edad = int.Parse(nudEdadCliente.Text);
            cliente.telefono = txtTelCliente.Text;

            ControladorEmpresa.GetInstancia().ModificarCliente(cliente);
            ListarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado() == null) return;
            Cliente cliente = ClienteSeleccionado().GetCliente();
     
            ControladorEmpresa.GetInstancia().EliminarCliente(cliente);
            ListarClientes();
        }

        private void ClientesComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarClientes();
        }
    }
}
