﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Sitio.Comun.Controles;
using Sitio.Comun.Clases;
using MeNet.Nucleo.AdministradorConsultas;
using MeNet.Nucleo.Controles;
using MeNet.Seguridad.Administrador;

namespace Sitio.Seguridad
{
    public partial class VerMenu : System.Web.UI.Page
    {
        //private static AdministradorConfiguracion administradorNegocio;

        #region variables
        private static AdministradorSeguridad administrarSeguridad;
        private static GeneradorControlesWeb generadorControles;
        private static Control contenedor;



        #endregion

        #region propiedades


        #endregion


        #region métodos de eventos

        protected void Page_PreInit(object sender, EventArgs e)
        {
            ucWebBarraProgreso1.Activar();
            if (!IsPostBack)
            {
                administrarSeguridad = AdministradorSistema.ControaldorAplicacion.AdministradorSeguridad;
                //administrarSeguridad.SesionSistemaActual.ClaveAplicacion = ClaveAplicacion;
                administrarSeguridad.IniciarSesionUsuario();
                generadorControles = new GeneradorControlesWeb();
                generadorControles.Iniciar();
                //DefinirCaptura();
            }
            Page.Theme = administrarSeguridad.SesionUsuarioActual.Tema;
            string IdMenu = Page.Request.QueryString.ToString();
            if (IdMenu != null && IdMenu !=string.Empty)
                UcWebMenuFuncionalidad2.IdMenu = IdMenu;
            //CargarControles();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //ConfigurarIncial();
                //Configurar();

            }
            else
            {
                //Configurar();
            }

            ucWebBarraProgreso1.DesActivar();
        }

        #endregion
    }
}