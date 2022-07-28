using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADOR;

namespace VISTA
{
    public partial class EmpleadosComponent : UserControl
    {
        List<EmpleadoDataGrid> ListaEmpleados = new List<EmpleadoDataGrid>();
        List<Categoria> ListaCategorias = new List<Categoria>();
        int categoriaSeleccionada; //Indice
        int indiceEmpleado;
        Categoria categoria = new Categoria();


        public EmpleadosComponent()
        {
            InitializeComponent();
            ListarEmpleados();
            MostrarCategorias();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmEmpleados");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
                {
                    control.Enabled = true;
                }
                else
                {
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

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            ListaEmpleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            dgvEmpleados.DataSource = ListaEmpleados;
        }

        //Muestra las categorias en el ComboBox
        public void MostrarCategorias() 
        {
            ListaCategorias = ControladorEmpresa.GetInstancia().GetCategorias();

            cbxCategoria.Items.Clear();
            foreach (Categoria x in ListaCategorias)    // Agrego las categorias al ComboBox
            {
                cbxCategoria.Items.Add(x.nombre);
            }
        }

        //Asigna el empleado seleccionado en el dgv
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                indiceEmpleado = dgvEmpleados.SelectedRows[0].Index; //Asigna el indice del empleado seleccionado
            }
        }

        public EmpleadoDataGrid EmpleadoSeleccionado() //Devuelve el Empleado seleccionado en el dgv
        {
            return ListaEmpleados.ElementAt(indiceEmpleado);
        }

        //AGREGAR EMPLEADO
        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado() //Se construye un empleado
            {
                nombre = txtNombreEmp.Text,
                edad = int.Parse(nudEdadEmp.Text),
                salario = int.Parse(txtSalarioEmp.Text)
            };

            empleado.Categoria = ListaCategorias.ElementAt(categoriaSeleccionada);

            empleado.Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession(); //Asigna la Empresa al empleado            
            ControladorEmpresa.GetInstancia().AgregarEmpleado(empleado);
            ListarEmpleados();
        }

        //MODIFICAR EMPLEADO
        private void btnModificarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = EmpleadoSeleccionado().GetEmpleado();
            empleado.nombre = txtNombreEmp.Text;
            empleado.edad = int.Parse(nudEdadEmp.Text);
            empleado.salario = int.Parse(txtSalarioEmp.Text);

            empleado.Categoria = ListaCategorias.ElementAt(cbxCategoria.SelectedIndex);

            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado);
            ListarEmpleados();
        }

        //ELIMINAR EMPLEADO
        private void btnEliminarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = EmpleadoSeleccionado().GetEmpleado();

            ControladorEmpresa.GetInstancia().EliminarEmpleado(empleado);
            ListarEmpleados();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmJerarquia jerarquia = new frmJerarquia(ListaEmpleados[e.RowIndex].GetEmpleado());
            jerarquia.Show();
        }

        private void EmpleadosComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarEmpleados();
        }
    }
}
