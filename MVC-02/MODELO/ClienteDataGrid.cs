using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ClienteDataGrid
    {
        private readonly Cliente _cliente;
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }

        public ClienteDataGrid(Cliente cliente)
        {
            _cliente = cliente;
            Nombre = _cliente.nombre;
            Edad = _cliente.edad;
            Telefono = _cliente.telefono;
        }

        public Cliente GetCliente()
        {
            return _cliente;
        }
    }
}
