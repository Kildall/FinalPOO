using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO.Seguridad;
using CONTROLADOR;

namespace VISTA
{
    public partial class frmSeleccionarPermisos : Form
    {
        private List<PermisoDataGrid> permisos;
        public List<PermisoDataGrid> permisosSeleccionados;

        private bool filtrado = false;

        public frmSeleccionarPermisos(List<PermisoDataGrid> permisos)
        {
            InitializeComponent();
            permisosSeleccionados = permisos;
            ActualizarLista();
            var temp = ControladorSeguridad.GetInstancia().GetFormularios().Select(x => x.nombre).ToList();
            temp.Insert(0, "");
            cbFormularios.DataSource = temp;
            
        }

        public void ActualizarLista()
        {
            if (filtrado)
            {
                lbPermisosSeleccionados.DataSource = null;
                dgvPermisos.DataSource = null;
                permisos = ControladorSeguridad.GetInstancia().GetPermisos().Where(x => !permisosSeleccionados.Any(y => y.GetPermiso().Id == x.GetPermiso().Id) && x.Formulario == cbFormularios.SelectedItem as string).ToList();
                dgvPermisos.DataSource = permisos;
                lbPermisosSeleccionados.DataSource = permisosSeleccionados.Select(x => x.Nombre).ToList();

            }
            else
            {
                lbPermisosSeleccionados.DataSource = null;
                dgvPermisos.DataSource = null;
                permisos = ControladorSeguridad.GetInstancia().GetPermisos().Where(x => !permisosSeleccionados.Any(y => y.GetPermiso().Id == x.GetPermiso().Id)).ToList();
                dgvPermisos.DataSource = permisos;
                lbPermisosSeleccionados.DataSource = permisosSeleccionados.Select(x => x.Nombre).ToList();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPermisos.SelectedCells.Count == 0 || dgvPermisos.SelectedCells[0].RowIndex == -1) return;
            permisosSeleccionados.Add(permisos[dgvPermisos.SelectedCells[0].RowIndex]);
            ActualizarLista();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            if (lbPermisosSeleccionados.SelectedIndex == -1) return;
            permisosSeleccionados.RemoveAt(lbPermisosSeleccionados.SelectedIndex);
            ActualizarLista();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvPermisos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            permisosSeleccionados.Add(permisos[e.RowIndex]);
            ActualizarLista();
        }

        private void cbFormularios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbFormularios.SelectedItem as string == "")
                filtrado = false;
            else
                filtrado = true;

            ActualizarLista();
        }
    }
}
