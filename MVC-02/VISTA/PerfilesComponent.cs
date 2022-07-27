using CONTROLADOR;
using MODELO;
using MODELO.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class PerfilesComponent : UserControl
    {
        private List<UsuarioDataGrid> usuariosDelPerfil;
        private List<PerfilDataGrid> perfiles;
        private List<EmpresaDataGrid> empresas;
        private PerfilDataGrid perfilSeleccionado;
        private List<Formulario> formulariosPerfil;
        private List<PermisoDataGrid> permisosPerfil = new List<PermisoDataGrid>();

        private bool creandoPerfil = false;

        public PerfilesComponent()
        {
            InitializeComponent();
            ActualizarLista();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmPerfiles");
            foreach (var control in GetButtonControls(this))
            {
                var permiso = permisos.FirstOrDefault(x => x == control.Name);
                if (permiso != null)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }

            var datos = this.Controls.Cast<Control>().FirstOrDefault(x => x.Name == "gbDatos");
            if (datos != null)
            {
                gbDatos.Enabled = permisos.Contains("gbDatos");
            }
            gbPerfil.Enabled = false;
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

        public void ActualizarLista()
        {
            dgvPerfiles.DataSource = null;
            cbEmpresa.DataSource = null;
            perfiles = ControladorSeguridad.GetInstancia().GetPerfiles();
            empresas = ControladorEmpresa.GetInstancia().GetEmpresas();
            dgvPerfiles.DataSource = perfiles;
            cbEmpresa.DataSource = empresas.Select(x => x.Nombre).ToList();
        }

        private void dgvPerfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            gbPerfil.Enabled = true;
            btnCrearPerfil.Enabled = false;
            btnAgregarPerfil.Text = "Modificar Perfil";
            dgvUsuarios.DataSource = null;
            lbFormularios.DataSource = null;
            lbPermisos.DataSource = null;

            perfilSeleccionado = perfiles[e.RowIndex];
            usuariosDelPerfil = ControladorSeguridad.GetInstancia().GetUsuariosByPerfil(perfilSeleccionado.GetPerfil().Id);
            dgvUsuarios.DataSource = usuariosDelPerfil;

            formulariosPerfil = perfilSeleccionado.GetPerfil().Formularios.ToList();
            permisosPerfil.Clear();
            foreach (var permiso in perfilSeleccionado.GetPerfil().Permisos)
            {
                permisosPerfil.Add(new PermisoDataGrid(permiso)
                {
                    Formulario = permiso.Formulario.nombre
                });
            }

            tbNombre.Text = perfilSeleccionado.Nombre;
            cbEmpresa.SelectedIndex = empresas.FindIndex(x => x.GetEmpresa().Id == perfilSeleccionado.GetPerfil().empresa_id);
            lbFormularios.DataSource = formulariosPerfil.Select(x => x.nombre).ToList();
            lbPermisos.DataSource = permisosPerfil.Select(x => x.Nombre).ToList();
        }

        private void btnAgregarFormulario_Click(object sender, EventArgs e)
        {
            frmSeleccionarFormulario selForm = new frmSeleccionarFormulario(perfilSeleccionado.GetPerfil().Formularios.ToList());
            if (selForm.ShowDialog() == DialogResult.OK)
            {
                perfilSeleccionado.GetPerfil().Formularios.Add(selForm.formulario);
                formulariosPerfil = perfilSeleccionado.GetPerfil().Formularios.ToList();
                lbFormularios.DataSource = formulariosPerfil.Select(x => x.nombre).ToList();
            }
        }

        private void btnEliminarFormulario_Click(object sender, EventArgs e)
        {
            if (lbFormularios.SelectedIndex == -1) return;
            if(MessageBox.Show($"Desea eliminar el acceso al formulario -> {lbFormularios.SelectedItem as string}","Eliminar formulario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                perfilSeleccionado.GetPerfil().Formularios.Remove(formulariosPerfil[lbFormularios.SelectedIndex]);
                formulariosPerfil = perfilSeleccionado.GetPerfil().Formularios.ToList();
                lbFormularios.DataSource = formulariosPerfil.Select(x => x.nombre).ToList();
            }
        }

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            gbPerfil.Enabled = true;
            btnCrearPerfil.Enabled = false;
            creandoPerfil = true;
            btnAgregarPerfil.Text = "Agregar Perfil";
            perfilSeleccionado = new PerfilDataGrid(new Perfil { nombre = "", empresa_id = 0});
        }

        private void btnAgregarPerfil_Click(object sender, EventArgs e)
        {
            if (creandoPerfil)
            {
                ControladorSeguridad.GetInstancia().AgregarPerfil(new Perfil()
                {
                    nombre = tbNombre.Text,
                    empresa_id = empresas[cbEmpresa.SelectedIndex].GetEmpresa().Id,
                    Formularios = perfilSeleccionado.GetPerfil().Formularios
                });
            } else
            {
                ControladorSeguridad.GetInstancia().ModificarPerfil();
            }
            btnCrearPerfil.Enabled = true;
            gbPerfil.Enabled = false;
            tbNombre.Text = string.Empty;
            cbEmpresa.SelectedIndex = 0;
            lbFormularios.DataSource = null;
            lbPermisos.DataSource = null;

            ActualizarLista();
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            frmSeleccionarPermisos selForm = new frmSeleccionarPermisos(permisosPerfil);
            if (selForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var permiso in selForm.permisosSeleccionados)
                    perfilSeleccionado.GetPerfil().Permisos.Add(permiso.GetPermiso());

                permisosPerfil.Clear();
                foreach (var permiso in perfilSeleccionado.GetPerfil().Permisos)
                {
                    permisosPerfil.Add(new PermisoDataGrid(permiso)
                    {
                        Formulario = permiso.Formulario.nombre
                    });
                }
                
                lbPermisos.DataSource = permisosPerfil.Select(x => x.Nombre).ToList();
            }
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            if (lbPermisos.SelectedIndex == -1) return;
            perfilSeleccionado.GetPerfil().Permisos.Remove(permisosPerfil[lbPermisos.SelectedIndex].GetPermiso());
            permisosPerfil.RemoveAt(lbPermisos.SelectedIndex);
            lbPermisos.DataSource = permisosPerfil.Select(x => x.Nombre).ToList();
        }
    }
}
