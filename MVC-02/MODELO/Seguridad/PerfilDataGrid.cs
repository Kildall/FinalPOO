using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Seguridad
{
    public class PerfilDataGrid
    {
        private Perfil _perfil;
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public int Cantidad { get; set; }

        public PerfilDataGrid(Perfil perfil)
        {
            this.Nombre = perfil.nombre;
            _perfil = perfil;
        }

        public Perfil GetPerfil()
        {
            return _perfil;
        }
    }
}
