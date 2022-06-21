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
        List<Empleado> ListaEmpleados = new List<Empleado>();
        List<Categoria> ListaCategorias = new List<Categoria>();
        int categoriaSeleccionada; //Indice
        int indiceEmpleado;
        Categoria categoria = new Categoria();


        public EmpleadosComponent()
        {
            InitializeComponent();
            ListarEmpleados();
            MostrarCategorias();
        }

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            ListaEmpleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            dgvEmpleados.DataSource = ListaEmpleados;
            dgvEmpleados.Columns.Remove("Empresa");
            dgvEmpleados.Columns.Remove("Superior");
            dgvEmpleados.Columns.Remove("Subordinados");
        }

        public void MostrarCategorias() //Muestra las categorias en el ComboBox
        {
            ListaCategorias = ControladorEmpresa.GetInstancia().GetCategorias();

            cbxCategoria.Items.Clear();
            foreach (Categoria x in ListaCategorias)    // Agrego las categorias al ComboBox
            {
                cbxCategoria.Items.Add(x.nombre);
            }      
        }


        //Asigna la categoria seleccionada
        private void cbxCategoria_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            categoriaSeleccionada = cbxCategoria.SelectedIndex;
        }

        //Asigna el empleado seleccionado en el dgv
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                indiceEmpleado = dgvEmpleados.SelectedRows[0].Index; //Asigna el indice del empleado seleccionado
            }
        }

        public Empleado EmpleadoSeleccionado() //Devuelve el Empleado seleccionado en el dgv
        {
            return ListaEmpleados.ElementAt(indiceEmpleado);
        }

        //AGREGAR EMPLEADO
        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado() //Se construye un empleado
            {
                nombre = txtNombreEmp.Text,
                edad = nudEdadEmp.Text,
                salario = txtSalarioEmp.Text
            };

            empleado.Categoria = ListaCategorias.ElementAt(categoriaSeleccionada);

            empleado.Empresa = ControladorEmpresa.GetInstancia().GetEmpresa(); //Asigna la Empresa al empleado            
            ControladorEmpresa.GetInstancia().AgregarEmpleado(empleado);
            ListarEmpleados();
        }

        //MODIFICAR EMPLEADO
        private void btnModificarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = EmpleadoSeleccionado();
            empleado.nombre = txtNombreEmp.Text;
            empleado.edad = nudEdadEmp.Text;
            empleado.salario = txtSalarioEmp.Text;

            empleado.Categoria = ListaCategorias.ElementAt(categoriaSeleccionada);

            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado);
            ListarEmpleados();
        }

        //ELIMINAR EMPLEADO
        private void btnEliminarEmpl_Click(object sender, EventArgs e)
        {
            Empleado empleado = EmpleadoSeleccionado();

            ControladorEmpresa.GetInstancia().EliminarEmpleado(empleado);
            ListarEmpleados();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmJerarquia jerarquia = new frmJerarquia(ListaEmpleados[e.RowIndex]);
            jerarquia.Show();
        }
    }
}
