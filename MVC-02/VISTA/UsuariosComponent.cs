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
using MODELO.Seguridad;

namespace VISTA
{
    public partial class UsuariosComponent : UserControl
    {
        public List<UsuarioDataGrid> usuarios; 
        public UsuariosComponent()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            dgvUsuarios.DataSource = null;

            usuarios = ControladorSeguridad.GetInstancia().GetUsuarios();

            dgvUsuarios.DataSource = usuarios;
        }
    }
}
