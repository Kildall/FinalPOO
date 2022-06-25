using MODELO;
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

namespace VISTA
{
    public partial class frmJerarquia : Form
    {
        private Empleado _empleado;
        List<Empleado> EmpleadosSuperiores;
        List<Empleado> EmpleadosSubordinados;


        public frmJerarquia(Empleado empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            dgvSubordinados.DataSource = null;
            dgvSuperiores.DataSource = null;
            lbEmpleadosSubordinados.DataSource = null;
            lbEmpleadosSuperiores.DataSource = null;
            dgvSuperiores.DataSource = _empleado.Superior.ToList();
            dgvSubordinados.DataSource = _empleado.Subordinados.ToList();

            EmpleadosSuperiores = ControladorEmpresa.GetInstancia().GetEmpleados()
                .Where(x => 
                !_empleado.Superior.Contains(x) && 
                _empleado != x &&
                !_empleado.Subordinados.Contains(x))
                .ToList();

            EmpleadosSubordinados = ControladorEmpresa.GetInstancia().GetEmpleados()
                .Where(x => 
                !_empleado.Subordinados.Contains(x) &&
                _empleado != x &&
                !_empleado.Superior.Contains(x))
                .ToList();

            //Lista de empleados en la seccion de subordinados, la lleno con los empleados que todavia no son subordinados de este caso
            lbEmpleadosSubordinados.DataSource = EmpleadosSubordinados.Select(x => x.nombre).ToList();

            //Lista de empleados en la seccion de superiores, la lleno con los empleados que todavia no son superiores de este caso
            lbEmpleadosSuperiores.DataSource = EmpleadosSuperiores.Select(x => x.nombre).ToList();

        }

        private void btnAgregarSuperior_Click(object sender, EventArgs e)
        {
            if (lbEmpleadosSuperiores.SelectedItems.Count == 0 || lbEmpleadosSuperiores.SelectedItems[0] == null) return;

            _empleado.Superior.Add(EmpleadosSuperiores[lbEmpleadosSuperiores.SelectedIndex]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(_empleado);
            ActualizarLista();
        }

        private void btnEliminarSuperior_Click(object sender, EventArgs e)
        {
            if (dgvSuperiores.SelectedRows.Count == 0) return;

            _empleado.Superior.Remove(_empleado.Superior.ToList()[dgvSuperiores.SelectedRows[0].Index]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(_empleado);
            ActualizarLista();
        }

        private void btnAgregarSubordinados_Click(object sender, EventArgs e)
        {
            if (lbEmpleadosSubordinados.SelectedItems.Count == 0 || lbEmpleadosSubordinados.SelectedItems[0] == null) return;

            _empleado.Subordinados.Add(EmpleadosSubordinados[lbEmpleadosSubordinados.SelectedIndex]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(_empleado);
            ActualizarLista();

        }

        private void btnEliminarSubordinados_Click(object sender, EventArgs e)
        {
            if (dgvSubordinados.SelectedRows.Count == 0) return;

            _empleado.Subordinados.Remove(_empleado.Subordinados.ToList()[dgvSubordinados.SelectedRows[0].Index]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(_empleado);
            ActualizarLista();
        }
    }
}
