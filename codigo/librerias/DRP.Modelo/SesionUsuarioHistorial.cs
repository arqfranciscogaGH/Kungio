//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DRP.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class SesionUsuarioHistorial
    {
        public int IdSesionHistorial { get; set; }
        public Nullable<int> IdSesion { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string LlaveSesion { get; set; }
        public string CuentaUsuario { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string AgenteSesion { get; set; }
        public string Dispositivo { get; set; }
        public string Equipo { get; set; }
        public Nullable<int> IdSuscriptor { get; set; }
        public string ClaveAplicacion { get; set; }
    }
}
