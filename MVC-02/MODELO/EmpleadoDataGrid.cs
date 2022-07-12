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
        public List<Empleado> Superiores { get; set; }
        public List<Empleado> Subordinados { get; set; }

        public EmpleadoDataGrid(Empleado empleado)
        {
            _empleado = empleado;
            Nombre = empleado.nombre;
            Edad = empleado.edad;
            Salario = empleado.salario;
            Categoria = empleado.Categoria.nombre;
            Superiores = new List<Empleado>();
            Subordinados = new List<Empleado>();

            foreach (Empleado x in empleado.Superior)
                Superiores.Add(x);

            foreach (Empleado x in empleado.Subordinados)
                Subordinados.Add(x);
            
        }

        public Empleado GetEmpleado()
        {
            return _empleado;
        }
    }
}
