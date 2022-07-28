using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using MODELO;
using MODELO.Seguridad;

namespace VISTA
{
    public partial class UsuariosComponent : UserControl
    {
        private List<UsuarioDataGrid> usuarios;
        private List<EmpresaDataGrid> empresas;

        private UsuarioDataGrid usuarioSeleccionado;
        private List<PerfilDataGrid> perfilesEmpresaActual;

        private bool empresaModificada = false;
        public UsuariosComponent()
        {
            InitializeComponent();
            ActualizarListaUsuarios();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmUsuarios");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
                {
                    control.Enabled = true;
                }
                else
                {
                    if (control.Name == "btnModificarUsuario")
                    {
                        dgvUsuarios.CellDoubleClick -= dgvUsuarios_CellDoubleClick;
                    }
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

        private void ActualizarListaUsuarios()
        {
            dgvUsuarios.DataSource = null;
            usuarios = ControladorSeguridad.GetInstancia().GetUsuarios();
            empresas = ControladorEmpresa.GetInstancia().GetEmpresas();
            dgvUsuarios.DataSource = usuarios;
            cbBusquedaEmpresa.DataSource = empresas.Select(x => x.Nombre).ToList();
        }

        private void ActualizarCamposUsuario()
        {

            //Perfiles
            perfilesEmpresaActual = ControladorSeguridad.GetInstancia().GetPerfilesByEmpresa(usuarioSeleccionado.GetUsuario().empresa_id);
            cbPerfiles.DataSource = perfilesEmpresaActual.Select(x => x.Nombre).ToList();

            if (!empresaModificada)
            {
                cbPerfiles.SelectedIndex =
                    perfilesEmpresaActual.FindIndex(x => x.GetPerfil().Id == usuarioSeleccionado.GetUsuario().Perfil.Id);
            }
            else
            {
                cbPerfiles.SelectedIndex = perfilesEmpresaActual.FindIndex(x => x.Nombre == "Nadie");
            }
            
            //Datos
            tbNombre.Text = usuarioSeleccionado.Nombre;
            tbApellido.Text = usuarioSeleccionado.Apellido;
            nudDNI.Value = usuarioSeleccionado.DNI;
            tbEmail.Text = usuarioSeleccionado.EMail;
            
        }

        private void ActualizarEmpresaUsuario()
        {
            cbEmpresa.DataSource = null;
            cbEmpresa.DataSource = empresas.Select(x => x.Nombre).ToList();
            cbEmpresa.SelectedIndex =
                empresas.FindIndex(x => x.GetEmpresa().Id == usuarioSeleccionado.GetUsuario().empresa_id);
        }


        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null) {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }
            
            if (!ValidateEmail(tbEmail.Text))
            {
                MessageBox.Show("El mail ingresado es inválido.");
                return;
            }

            if (tbEmail.Text != usuarioSeleccionado.EMail && ControladorSeguridad.GetInstancia().ExisteEmail(tbEmail.Text))
            {
                MessageBox.Show("El mail ingresado ya existe.");
                return;
            }

            if (String.IsNullOrEmpty(tbNombre.Text) || !tbNombre.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El nombre ingresado es inválido.");
                return;
            }

            if (String.IsNullOrEmpty(tbApellido.Text) || !tbApellido.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El apellido ingresado es inválido.");
                return;
            }

            if (nudDNI.Value >= 99999999 || nudDNI.Value <= 100000)
            {
                MessageBox.Show("El DNI ingresado es inválido.");
                return;
            }

            Usuario usu = usuarioSeleccionado.GetUsuario();
            usu.nombre = tbNombre.Text;
            usu.apellido = tbApellido.Text;
            usu.dni = (long)nudDNI.Value;
            usu.mail = tbEmail.Text;
            ControladorSeguridad.GetInstancia().ModificarUsuario();
            empresaModificada = false;
            ActualizarListaUsuarios();
            LimpiarCampos();

            MessageBox.Show("Usuario modificado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ValidateEmail(string email)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            return validateEmailRegex.IsMatch(email);
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            usuarioSeleccionado = usuarios[e.RowIndex];
            ActualizarCamposUsuario();
            ActualizarEmpresaUsuario();
        }

        private void cbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedIndex > empresas.Count - 1 || cbEmpresa.SelectedIndex < 0) return;
            usuarioSeleccionado.GetUsuario().empresa_id = empresas[cbEmpresa.SelectedIndex].GetEmpresa().Id;
            ActualizarEmpresaUsuario();
            empresaModificada = true;
            ActualizarCamposUsuario();
            usuarioSeleccionado.GetUsuario().Perfil = perfilesEmpresaActual[cbPerfiles.SelectedIndex].GetPerfil();
        }

        private void cbPerfiles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPerfiles.SelectedIndex > perfilesEmpresaActual.Count - 1 || cbPerfiles.SelectedIndex < 0) return;
            usuarioSeleccionado.GetUsuario().Perfil = perfilesEmpresaActual[cbPerfiles.SelectedIndex].GetPerfil();
            ActualizarCamposUsuario();
        }

        private void cbBusquedaEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBusquedaEmpresa.SelectedIndex > empresas.Count - 1 || cbBusquedaEmpresa.SelectedIndex < 0) return;
            tbBusquedaDNI.Text = null;
            dgvUsuarios.DataSource = ControladorSeguridad.GetInstancia()
                .GetUsuariosByEmpresa(empresas[cbBusquedaEmpresa.SelectedIndex].GetEmpresa().Id);
        }

        private void tbBusquedaDNI_TextChanged(object sender, EventArgs e)
        {
            if (tbBusquedaDNI.Text == null) return;
            if (tbBusquedaDNI.Text == String.Empty) 
                ActualizarListaUsuarios();
            else
            {
                dgvUsuarios.DataSource = usuarios.Where(x => x.DNI.ToString().Contains(tbBusquedaDNI.Text)).ToList();
            }


        }

        private void UsuariosComponent_Paint(object sender, PaintEventArgs e)
        {
            ActualizarListaUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null || usuarioSeleccionado.GetUsuario() == ControladorSeguridad.GetInstancia().usuarioLogueado) return;
            if(MessageBox.Show($"Seguro quiere eliminar el usuario {usuarioSeleccionado.Nombre} {usuarioSeleccionado.Apellido}?"
                , "Eliminar Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ControladorSeguridad.GetInstancia().EliminarUsuario(usuarioSeleccionado.GetUsuario());
                ActualizarListaUsuarios();
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            usuarioSeleccionado = null;
            tbNombre.Text = null;
            tbApellido.Text = null;
            nudDNI.Value = 0;
            tbEmail.Text = null;
            cbEmpresa.SelectedItem = null;
            cbPerfiles.SelectedItem = null;
        }
    }
}
