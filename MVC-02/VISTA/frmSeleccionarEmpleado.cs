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
    public partial class frmSeleccionarEmpleado : Form
    {
        private List<EmpleadoDataGrid> empleados;
        public EmpleadoDataGrid empleado;
        public frmSeleccionarEmpleado()
        {
            InitializeComponent();
            empleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            lbEmpleados.DataSource = empleados.Select(x => x.Nombre).ToList();
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            if(lbEmpleados.SelectedIndex != -1)
            {
                empleado = empleados[lbEmpleados.SelectedIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
