﻿using System;
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
            tbDNI.Text = usuarioSeleccionado.DNI;
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
            Usuario usu = usuarioSeleccionado.GetUsuario();
            usu.nombre = tbNombre.Text;
            usu.apellido = tbApellido.Text;
            usu.dni = tbDNI.Text;
            usu.mail = tbEmail.Text;
            ControladorSeguridad.GetInstancia().ModificarUsuario();
            empresaModificada = false;
            ActualizarListaUsuarios();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
                dgvUsuarios.DataSource = usuarios.Where(x => x.DNI.Contains(tbBusquedaDNI.Text)).ToList();
            }


        }
    }
}