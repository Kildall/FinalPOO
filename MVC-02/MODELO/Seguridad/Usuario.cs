//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELO.Seguridad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string contraseña { get; set; }
    
        public virtual Perfil Perfil { get; set; }
    }
}
