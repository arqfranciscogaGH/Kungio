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
    
    public partial class Domicilio
    {
        public int IdDomicilio { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string TipoDomicilio { get; set; }
        public Nullable<double> Longitud { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<int> IdPais { get; set; }
        public string Pais { get; set; }
        public string ClaveEstado { get; set; }
        public string Estado { get; set; }
        public string ClaveMunicipio { get; set; }
        public string Municipio { get; set; }
        public string ClaveLocalidad { get; set; }
        public string Localidad { get; set; }
        public string ClaveColonia { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }
        public string Calle { get; set; }
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public Nullable<int> IdSuscriptor { get; set; }
        public Nullable<bool> Activo { get; set; }
    }
}
