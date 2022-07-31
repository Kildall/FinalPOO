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
    public partial class frmSeleccionarCliente : Form
    {
        private List<ClienteDataGrid> clientes;
        public ClienteDataGrid cliente;
        public frmSeleccionarCliente()
        {
            InitializeComponent();
            clientes = ControladorEmpresa.GetInstancia().GetClientes();
            lbClientes.DataSource = clientes.Select(x => x.Nombre).ToList();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if(lbClientes.SelectedIndex != -1)
            {
                cliente = clientes[lbClientes.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
