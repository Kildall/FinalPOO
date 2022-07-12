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
        public VentasComponent()
        {
            InitializeComponent();
            ListarInfoVenta();
        }

        public void ListarInfoVenta()
        {
            cbxCliente.Items.Clear();
            foreach (var x in ControladorEmpresa.GetInstancia().GetClientes())
            {
                cbxCliente.Items.Add(x.GetCliente().nombre);
            }

            cbxProductos.Items.Clear();
            foreach (var x in ControladorEmpresa.GetInstancia().GetProductos())
            {
                cbxProductos.Items.Add(x.GetProductos().nombre);
            }

            cbxEmpleados.Items.Clear();
            foreach (var x in ControladorEmpresa.GetInstancia().GetEmpleados())
            {
                cbxEmpleados.Items.Add(x.GetEmpleado().nombre);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
