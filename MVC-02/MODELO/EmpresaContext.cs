using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class EmpresaContext
    {
        private static EmpresaContext _instancia;

        private static EmpresaDBContainer _container;
        private EmpresaContext() { }

        public static EmpresaContext GetInstancia()
        {
            if (_instancia == null )
            {
                _instancia = new EmpresaContext();
                _container = new EmpresaDBContainer();
            }
            return _instancia;
        }

        public EmpresaDBContainer GetContainer
        {
            get { return _container; }
        }

    }
}
