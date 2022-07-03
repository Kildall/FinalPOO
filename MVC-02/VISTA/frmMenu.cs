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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            switch (ControladorSeguridad.GetInstancia().usuarioLogueado.Perfil.nombre)
            {
                case "Empleado":
                    //Deshabilitar o esconder todo menos clientes
                    break;

                case "Gerente":
                    //Deshabilitar o esconder jerarquia
                    break;

                case "Cliente":
                    //Deshabilitar o esconder todo menos productos
                    break;

                case "Dueño":
                    //Mostrarle todo
                    break;

                case "Nadie":
                    break;

                default:
                    throw new Exception("Perfil desconocido");
            }
            //panelMenu.Controls.Clear();
            //panelMenu.Controls.Add(new EmpleadosComponent());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new EmpleadosComponent());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new ClientesComponent());
        }
    }
}
