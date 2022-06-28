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
                edad = nudEdadCliente.Text,
                telefono = txtTelCliente.Text,
            };

            //Asigna la empresa al cliente
            cliente.Empresa = ControladorEmpresa.GetInstancia().GetEmpresa();

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
            return ListaClientes.ElementAt(indice);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteSeleccionado().GetCliente();
            cliente.nombre = txtNombreCliente.Text;
            cliente.edad = nudEdadCliente.Text;
            cliente.telefono = txtTelCliente.Text;

            ControladorEmpresa.GetInstancia().ModificarCliente(cliente);
            ListarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteSeleccionado().GetCliente();
     
            ControladorEmpresa.GetInstancia().EliminarCliente(cliente);
            ListarClientes();
        }
    }
}
