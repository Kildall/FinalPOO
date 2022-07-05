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
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }

        public List<UsuarioDataGrid> GetUsuariosByEmpresa(int empresa_id)
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstance().Container.UsuarioSet.Where(x => x.empresa_id == empresa_id))
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }

        public List<UsuarioDataGrid> GetUsuariosByPerfil(int perfil_id)
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstance().Container.UsuarioSet.Where(x => x.Perfil.Id == perfil_id))
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }

        public List<PerfilDataGrid> GetPerfilesByEmpresa(int empresa_id)
        {
            List<PerfilDataGrid> listaPerfiles = new List<PerfilDataGrid>();
            foreach (var perfil in SeguridadContext.GetInstance().Container.PerfilSet.Where(x => x.empresa_id == empresa_id))
                listaPerfiles.Add(new PerfilDataGrid(perfil)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(perfil.empresa_id).nombre,
                    Cantidad = GetUsuariosByPerfil(perfil.Id).Count

                });

            return listaPerfiles;
        }

        public List<PerfilDataGrid> GetPerfiles()
        {
            List<PerfilDataGrid> listaPerfiles = new List<PerfilDataGrid>();
            foreach (var perfil in SeguridadContext.GetInstance().Container.PerfilSet)
                listaPerfiles.Add(new PerfilDataGrid(perfil)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(perfil.empresa_id).nombre,
                    Cantidad = GetUsuariosByPerfil(perfil.Id).Count
                });

            return listaPerfiles;
        }

        public void ModificarPerfil()
        {
            SeguridadContext.GetInstance().Container.SaveChanges();
        }

        public List<Formulario> GetFormularios()
        {
            return SeguridadContext.GetInstance().Container.FormularioSet.ToList();
        }

        public void ModificarUsuario()
        {
            SeguridadContext.GetInstance().Container.SaveChanges();
        }

        public void AgregarPerfil(Perfil perfil)
        {
            SeguridadContext.GetInstance().Container.PerfilSet.Add(perfil);
            SeguridadContext.GetInstance().Container.SaveChanges();
        }

        public List<PermisoDataGrid> GetPermisos()
        {
            List<PermisoDataGrid> listaPermisos = new List<PermisoDataGrid>();
            foreach (var permiso in SeguridadContext.GetInstance().Container.PermisoSet)
                listaPermisos.Add(new PermisoDataGrid(permiso)
                {
                    Formulario = permiso.Formulario.nombre
                });

            return listaPermisos;
        }
    }
}
