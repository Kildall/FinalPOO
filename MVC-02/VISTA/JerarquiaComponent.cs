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
    public partial class JerarquiaComponent : UserControl
    {
        List<EmpleadoDataGrid> listaEmpleados = new List<EmpleadoDataGrid>();
        int indice;
        public JerarquiaComponent()
        {
            InitializeComponent();
            ListarEmpleados();
        }

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            listaEmpleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;
        }

    }
}
