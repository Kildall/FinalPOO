using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODELO.Seguridad;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    public class ControladorSeguridad
    {
        private static ControladorSeguridad _instancia;

        public static ControladorSeguridad GetInstancia()
        {
            if(_instancia == null) _instancia = new ControladorSeguridad();
            return _instancia;
        }

        public Usuario usuarioLogueado { get; private set; }

        public int Login(string email, string password)
        {
            Usuario user = SeguridadContext.GetInstance().Container.UsuarioSet.FirstOrDefault(x => x.mail == email);

            if (user == null) return 20;
            if (user.contraseña != password) return 40;
            usuarioLogueado = user;
            return 0;
        }

        public int Register(Usuario usuario)
        {
            if (SeguridadContext.GetInstance().Container.UsuarioSet.FirstOrDefault(x => x.mail == usuario.mail) != null)
                return 10;
            usuario.Perfil = SeguridadContext.GetInstance().Container.PerfilSet.Where(x => x.nombre == "Nadie" && x.empresa_id == usuario.empresa_id).First();
            SeguridadContext.GetInstance().Container.UsuarioSet.Add(usuario);
            SeguridadContext.GetInstance().Container.SaveChanges();
            return 0;
        }

        public List<UsuarioDataGrid> GetUsuarios()
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstance().Container.UsuarioSet)
                listaUsuarios.Add(new UsuarioDataGrid(usuario));

            return listaUsuarios;
        }

    }
}
