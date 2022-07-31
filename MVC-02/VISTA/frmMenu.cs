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
        public bool Logueado = true;
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
                if (ControladorSeguridad.GetInstancia().CanUsuarioViewFormulario(form.Key))
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
            var logoutItem = new ToolStripMenuItem("Cerrar Sesion");
            logoutItem.Click += (sender, e) =>
            {
                ControladorSeguridad.GetInstancia().Logout();
                this.Logueado = false;
                this.Close();
            };
            logoutItem.Alignment = ToolStripItemAlignment.Right;
            menuStrip1.Items.Add(logoutItem);
            if (menuStrip1.Items.Count > 1)
                panelMenu.Controls.Add(formularios["frm" + menuStrip1.Items[0].Text]);
        }
    }
}
