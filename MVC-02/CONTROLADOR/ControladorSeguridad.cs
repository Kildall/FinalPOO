using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MODELO.Seguridad;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        #region Login y Registro
        public int Login(string email, string password)
        {
            Usuario user = SeguridadContext.GetInstancia().Container.UsuarioSet.FirstOrDefault(x => x.mail == email);

            if (user == null) return 20;
            if (user.contraseña != Encriptacion(password)) return 40;
            usuarioLogueado = user;
            ControladorEmpresa.GetInstancia().empresa_id = usuarioLogueado.empresa_id;
            return 0;
        }
        public int Register(Usuario usuario)
        {
            if (SeguridadContext.GetInstancia().Container.UsuarioSet.FirstOrDefault(x => x.mail == usuario.mail) != null)
                return 10;
            usuario.Perfil = SeguridadContext.GetInstancia().Container.PerfilSet.Where(x => x.nombre == "Nadie" && x.empresa_id == usuario.empresa_id).First();
            usuario.contraseña = Encriptacion(usuario.contraseña);
            SeguridadContext.GetInstancia().Container.UsuarioSet.Add(usuario);
            SeguridadContext.GetInstancia().Container.SaveChanges();
            return 0;
        }
        public string Encriptacion(string contraseña)
        {
            //Creo el encriptador
            SHA256 sha256 = SHA256.Create();

            //Encripto el valor pasando el string recibido a bytes
            byte[] hash = sha256.ComputeHash(Encoding.Default.GetBytes(contraseña));

            //Creo un string
            string contraEncriptada = "";

            //Transformo todos los bytes en valores de string
            for (int i = 0; i < hash.Length; i++)
            {
                contraEncriptada += hash[i].ToString();
            }

            //Devuelvo el valor generado
            return contraEncriptada;
        }
        public void Logout()
        {
            this.usuarioLogueado = null;
            ControladorEmpresa.GetInstancia().empresa_id = -1;
        }
        #endregion

        #region Usuarios
        public List<UsuarioDataGrid> GetUsuarios()
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstancia().Container.UsuarioSet)
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }

        public List<UsuarioDataGrid> GetUsuariosByEmpresa(int empresa_id)
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstancia().Container.UsuarioSet.Where(x => x.empresa_id == empresa_id))
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }

        public List<UsuarioDataGrid> GetUsuariosByPerfil(int perfil_id)
        {
            List<UsuarioDataGrid> listaUsuarios = new List<UsuarioDataGrid>();
            foreach (var usuario in SeguridadContext.GetInstancia().Container.UsuarioSet.Where(x => x.Perfil.Id == perfil_id))
                listaUsuarios.Add(new UsuarioDataGrid(usuario)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(usuario.empresa_id).nombre
                });

            return listaUsuarios;
        }
        public void ModificarUsuario()
        {
            SeguridadContext.GetInstancia().Container.SaveChanges();
        }

        #endregion

        #region Perfiles
        public List<PerfilDataGrid> GetPerfilesByEmpresa(int empresa_id)
        {
            List<PerfilDataGrid> listaPerfiles = new List<PerfilDataGrid>();
            foreach (var perfil in SeguridadContext.GetInstancia().Container.PerfilSet.Where(x => x.empresa_id == empresa_id))
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
            foreach (var perfil in SeguridadContext.GetInstancia().Container.PerfilSet)
                listaPerfiles.Add(new PerfilDataGrid(perfil)
                {
                    Empresa = ControladorEmpresa.GetInstancia().GetEmpresaById(perfil.empresa_id).nombre,
                    Cantidad = GetUsuariosByPerfil(perfil.Id).Count
                });

            return listaPerfiles;
        }

        public void ModificarPerfil()
        {
            SeguridadContext.GetInstancia().Container.SaveChanges();
        }
        
        public void AgregarPerfil(Perfil perfil)
        {
            SeguridadContext.GetInstancia().Container.PerfilSet.Add(perfil);
            SeguridadContext.GetInstancia().Container.SaveChanges();
        }

        #endregion

        #region Formularios
        public List<Formulario> GetFormularios()
        {
            return SeguridadContext.GetInstancia().Container.FormularioSet.ToList();
        }
        #endregion

        #region Permisos
        public List<PermisoDataGrid> GetPermisos()
        {
            List<PermisoDataGrid> listaPermisos = new List<PermisoDataGrid>();
            foreach (var permiso in SeguridadContext.GetInstancia().Container.PermisoSet)
                listaPermisos.Add(new PermisoDataGrid(permiso)
                {
                    Formulario = permiso.Formulario.nombre
                });

            return listaPermisos;
        }
        public bool CanUsuarioViewFormulario(string form)
        {
            foreach (var formulario in usuarioLogueado.Perfil.Formularios)
            {
                if (formulario.nombre == form)
                {
                    return true;
                }
            }
            return false;
        }
        public List<string> GetPermisosByFormulario(string form)
        {
            return usuarioLogueado.Perfil.Permisos.Where(x => x.Formulario.nombre == form).Select(x => x.nombreSistema).ToList();
        }
        #endregion
    }
}
