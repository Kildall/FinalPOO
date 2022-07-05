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
    public partial class frmSeleccionarFormulario : Form
    {
        private List<Formulario> formularios;
        public Formulario formulario;
        public frmSeleccionarFormulario(List<Formulario> formulariosExistentes)
        {
            InitializeComponent();
            formularios = ControladorSeguridad.GetInstancia().GetFormularios().Where(x=> !formulariosExistentes.Contains(x)).ToList();
            lbFormularios.DataSource = formularios.Select(x => x.nombre).ToList();
        }

        private void btnSeleccionarFormulario_Click(object sender, EventArgs e)
        {
            if (lbFormularios.SelectedIndex == -1) return;
            formulario = formularios[lbFormularios.SelectedIndex];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
