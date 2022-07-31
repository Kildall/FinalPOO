using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Seguridad
{
    public class PermisoDataGrid
    {
        private Permiso _permiso;
        public string Nombre { get; private set; }
        public string Formulario { get; set; }
        public string Control { get; private set; }

        public PermisoDataGrid(Permiso permiso)
        {
            this.Nombre = permiso.nombre;
            this.Control = permiso.nombreSistema;
            _permiso = permiso;
        }

        public Permiso GetPermiso()
        {
            return _permiso;
        }
    }
}
