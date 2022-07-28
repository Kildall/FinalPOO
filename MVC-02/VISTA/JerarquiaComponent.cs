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
        List<EmpleadoDataGrid> listaEmpleadosSuperiores;
        List<EmpleadoDataGrid> listaEmpleadosSubordinados;
        EmpleadoDataGrid _empleado;
        int indice;
        public JerarquiaComponent()
        {
            InitializeComponent();
            ListarEmpleados();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmJerarquia");
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

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            listaEmpleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            dgvEmpleados.DataSource = listaEmpleados;

        }

        public void ListarSupSub()
        {
            listaEmpleadosSuperiores = new List<EmpleadoDataGrid>();
            listaEmpleadosSubordinados = new List<EmpleadoDataGrid>();
            if (indice >= 0)
            {
                dgvSuperiores.DataSource = null;
                foreach (Empleado x in listaEmpleados.ElementAt(indice).GetEmpleado().Superior)
                    listaEmpleadosSuperiores.Add((new EmpleadoDataGrid(x)));
                dgvSuperiores.DataSource = listaEmpleadosSuperiores;

                dgvSubordinados.DataSource = null;
                foreach (Empleado x in listaEmpleados.ElementAt(indice).GetEmpleado().Subordinados)
                    listaEmpleadosSubordinados.Add((new EmpleadoDataGrid(x)));
                dgvSubordinados.DataSource = listaEmpleadosSubordinados;
            }

        }

        public void ActualizarListBoxs(Empleado empleado)
        {
            lbEmpleadosSubordinados.Items.Clear();
            lbEmpleados.Items.Clear();

            listaEmpleadosSubordinados = ControladorEmpresa.GetInstancia().GetEmpleados().
                Where(x => !empleado.Superior.Contains(x.GetEmpleado()) &&
                empleado != x.GetEmpleado() &&
                !empleado.Subordinados.Contains(x.GetEmpleado()) &&
                !empleado.Subordinados.Contains(empleado)).ToList();

            //Se utiliza esta lista pero en realidad no son superiores
            listaEmpleadosSuperiores = ControladorEmpresa.GetInstancia().GetEmpleados().
                Where(x => !empleado.Subordinados.Contains(x.GetEmpleado()) &&
                empleado != x.GetEmpleado() &&
                !empleado.Superior.Contains(x.GetEmpleado())).ToList();

            foreach (EmpleadoDataGrid x in listaEmpleadosSubordinados)
                lbEmpleadosSubordinados.Items.Add(x.Nombre);

            foreach (EmpleadoDataGrid x in listaEmpleadosSuperiores)
                lbEmpleados.Items.Add(x.Nombre);
        }


        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                ListarSupSub();
                ActualizarListBoxs(listaEmpleados.ElementAt(indice).GetEmpleado());
            }
            
        }

        private void btnAgregarSuperior_Click(object sender, EventArgs e)
        {
            if (lbEmpleadosSubordinados.SelectedItems.Count == 0 || lbEmpleadosSubordinados.SelectedItems[0] == null)
            {
                MessageBox.Show("Por favor seleccione un empleado válido para subordinar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmpleadoDataGrid empleado = listaEmpleados.ElementAt(indice);
            empleado.GetEmpleado().Superior.Add(
                listaEmpleadosSuperiores[lbEmpleadosSubordinados.SelectedIndex].GetEmpleado());
            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado.GetEmpleado());
            ListarSupSub();
            ActualizarListBoxs(empleado.GetEmpleado());

        }

        private void btnEliminarSuperior_Click(object sender, EventArgs e)
        {
            if (dgvSuperiores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un empleado válido eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmpleadoDataGrid empleado = listaEmpleados.ElementAt(indice);
            empleado.GetEmpleado().Superior.Remove(
                empleado.GetEmpleado().Superior.ToList()[dgvSuperiores.SelectedRows[0].Index]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado.GetEmpleado());
            ListarSupSub();
            ActualizarListBoxs(empleado.GetEmpleado());
        }

        private void btnAgregarSubordinado_Click(object sender, EventArgs e)
        {
            if (lbEmpleados.SelectedItems.Count == 0 || lbEmpleados.SelectedItems[0] == null)
            {
                MessageBox.Show("Por favor seleccione un empleado válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmpleadoDataGrid empleado = listaEmpleados.ElementAt(indice);
            empleado.GetEmpleado().Subordinados.Add(
                listaEmpleadosSubordinados[lbEmpleados.SelectedIndex].GetEmpleado());
            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado.GetEmpleado());
            ListarSupSub();
            ActualizarListBoxs(empleado.GetEmpleado());
        }

        private void btnEliminarSubordinado_Click(object sender, EventArgs e)
        {
            if (dgvSubordinados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un empleado válido eliminar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmpleadoDataGrid empleado = listaEmpleados.ElementAt(indice);
            empleado.GetEmpleado().Subordinados.Remove(
                empleado.GetEmpleado().Subordinados.ToList()[dgvSubordinados.SelectedRows[0].Index]);
            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado.GetEmpleado());
            ListarSupSub();
            ActualizarListBoxs(empleado.GetEmpleado());
        }

        private void JerarquiaComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarEmpleados();
        }
    }
}
