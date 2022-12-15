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
    public class ConsultarEstadisticasController : ApiController
    {
        // GET: api/Movs/1/2/3
        //[ResponseType(typeof(ConsultarEstadisticas_Result))]
        //public IHttpActionResult GetEstadisticas(String latitud, String longitud, double? radio)
        //{
        //    //GeoContainer db = new GeoContainer();
        //    if (latitud == "''" || latitud == null)
        //        latitud = "19.6592532";
        //    if (longitud == "''" || longitud == null)
        //        longitud = "-99.2127038";
        //    if (radio == 0 || radio == null)
        //        radio = 10;
        //   /// ObjectResult<ConsultarEstadisticas_Result> resultado = db.ConsultarEstadisticas(latitud, longitud, radio);
        //    //var  resultado = db.ConsultarEstadisticas(latitud, longitud, radio);
        //    //return Ok(resultado);
        //}

    }

}
