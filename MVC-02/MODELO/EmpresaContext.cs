using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class EmpresaContext
    {
        private static EmpresaContext _instancia;   //Conexion a la base de datos

        private static EmpresaDBContainer _container; //Lo que esta dentro de la base de datos
        private EmpresaContext() { }

        public static EmpresaContext GetInstancia()
        {
            if (_instancia == null )
            {
                //Instancias de:
                _instancia = new EmpresaContext(); //Del contexto
                _container = new EmpresaDBContainer(); //Del contenedor
            }
            return _instancia;
        }

        public EmpresaDBContainer GetContainer
        {
            get { return _container; }
        }

    }
}
