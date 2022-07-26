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
            Dictionary<string, UserControl> formularios = new Dictionary<string, UserControl>();
            formularios.Add("frmPerfiles", new PerfilesComponent());
            formularios.Add("frmProductos", new ProductosComponent());
            formularios.Add("frmEmpleados", new EmpleadosComponent());
            formularios.Add("frmUsuarios", new UsuariosComponent());
            formularios.Add("frmVenta", new VentasComponent());
            formularios.Add("frmClientes", new ClientesComponent());
            formularios.Add("frmJerarquia", new JerarquiaComponent());

            menuStrip1.Items.Clear();
            foreach (var form in formularios)
            {
                if (ControladorSeguridad.GetInstancia().CanUserAccessForm(form.Key))
                {
                    var item = new ToolStripMenuItem(form.Key.Substring(3));
                    item.Click += (sender, e) =>
                    {
                        panelMenu.Controls.Clear();
                        panelMenu.Controls.Add(form.Value);
                    };
                    menuStrip1.Items.Add(item);
                    
                }
            }
         
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new UsuariosComponent());
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new PerfilesComponent());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new ProductosComponent());
        }

        private void jerarquiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new JerarquiaComponent());
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            panelMenu.Controls.Add(new VentasComponent());
        }
    }
}
