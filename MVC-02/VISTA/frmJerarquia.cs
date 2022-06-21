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

namespace VISTA
{
    public partial class frmJerarquia : Form
    {
        private Empleado _empleado;
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
            dgvSuperiores.DataSource = _empleado.Superior.ToList();
            dgvSubordinados.DataSource = _empleado.Subordinados.ToList();
        }
    }
}
