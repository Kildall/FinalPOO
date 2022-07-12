using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Seguridad
{
    public class SeguridadContext
    {
        private static SeguridadContext _instance;
        private static SeguridadContainer _container;

        private SeguridadContext() { }
        public static SeguridadContext GetInstancia()
        {
            if(_instance == null)
            {
                _instance = new SeguridadContext();
                _container = new SeguridadContainer();
            }

            return _instance;
        }

        public SeguridadContainer Container { 
            get { return _container; }
        }
    }
}
