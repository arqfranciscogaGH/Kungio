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
    
    public partial class NivelRed
    {
        public int id { get; set; }
        public string llave { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public Nullable<double> comision { get; set; }
        public Nullable<int> orden { get; set; }
        public Nullable<int> socios { get; set; }
        public Nullable<int> operaciones { get; set; }
        public Nullable<int> importes { get; set; }
        public string fechaEstatus { get; set; }
        public Nullable<short> estatus { get; set; }
        public string color { get; set; }
    }
}
