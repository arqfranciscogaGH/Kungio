﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

using MeNet.Nucleo.Contexto;
using MeNet.Nucleo.Negocio;
using MeNet.Nucleo.Modelo;
using DRP.Modelo;


namespace MeNet.Seguridad.Administrador
{
    public class AdministradorAplicacion : AdministradorNegocioEntidad<Aplicacion>
    {
        private ModeloSistema _contexto;
        public AdministradorAplicacion()
        {
            _contexto = (ModeloSistema)AdministradorContexto.Iniciar<ModeloSistema>();
            // se asigna contexto a clase base
            this.Contexto = _contexto;

        }
    }
}
