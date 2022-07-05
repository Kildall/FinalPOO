namespace MODELO.Seguridad
{
    public class UsuarioDataGrid
    {
        private Usuario _usuario;

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Contraseña { get; private set; }
        public string DNI { get; private set; }
        public string EMail { get; private set; }
        public string Perfil { get; private set; }
        public string Empresa { get; set; }

        public UsuarioDataGrid(Usuario usuario)
        {
            this.Nombre = usuario.nombre;
            this.Apellido = usuario.apellido;
            this.DNI = usuario.dni;
            this.EMail = usuario.mail;
            this.Perfil = usuario.Perfil.nombre;
            this.Contraseña = usuario.contraseña;
            _usuario = usuario;
        }

        public Usuario GetUsuario()
        {
            return _usuario;
        }
    }
}
