using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class EmpresaDataGrid
    {
        private Empresa _empresa;
        public string Nombre { get; private set; }
        public int Empleados { get; private set; }
        public int Ventas { get; private set; }
        public long Monto { get; private set; }

        public EmpresaDataGrid(Empresa empresa)
        {
            this.Nombre = empresa.nombre;
            this.Empleados = empresa.Empleados.Count;
            this.Ventas = empresa.Ventas.Count;
            this.Monto = empresa.Ventas.Select(x => x.total).Sum();
            _empresa = empresa;
        }


        public Empresa GetEmpresa()
        {
            return _empresa;
        }
    }
}
