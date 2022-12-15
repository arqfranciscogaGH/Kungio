using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Sitio.Models;
using System.Data.Entity.Core.Objects;
namespace Sitio.Controllers
{
    public class ConsultarNegociosController : ApiController
    {

        //[ResponseType(typeof(ConsultarNegocios_Result))]
        //public IHttpActionResult GetConsultarNegocios(String latitud, String longitud, double? radio, String giro)
        //{
        //    private GeoContainer db = new GeoContainer();

        ////if (latitud == "''" || latitud == null)
        ////    latitud = "19.6592532";
        ////if (longitud == "''" || longitud == null)
        ////    longitud = "-99.2127038";
        ////if (radio == 0 || radio == null)
        ////    radio = 10;
        //var resultado = db.ConsultarNegocios(latitud, longitud, radio, giro).ToList();
        //    return Ok(resultado);

        ////}
    }
}
