using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class EmpleadoDataGrid
    {

        private readonly Empleado _empleado;

        //public int ID { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Salario { get; set; }
        public string Categoria { get; set; }
        
        public EmpleadoDataGrid(Empleado empleado)
        {
            _empleado = empleado;
            Nombre = empleado.nombre;
            Edad = empleado.edad;
            Salario = empleado.salario;
            Categoria = empleado.Categoria.nombre;
        }

        public Empleado GetEmpleado()
        {
            return _empleado;
        }
    }
}
